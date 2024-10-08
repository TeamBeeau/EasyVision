#include "CCD.h"
using namespace CvPlus; 
using namespace System::Runtime::InteropServices;
uchar* MatToBytes(cv::Mat image)
{
	int image_size = image.total() * image.elemSize();
	uchar* image_uchar = new uchar[image_size];
	//image_uchar is a class data member of uchar*
	std::memcpy(image_uchar, image.data, image_size * sizeof(uchar));
	return image_uchar;
}
cv::Mat BytesToMat(uchar* uc, int image_rows, int image_cols, int image_type)
{
	cv::Mat img(image_rows, image_cols, image_type, uc, cv::Mat::AUTO_STEP);
	
	return img;
}
void ReadImage()
{

	ucRaw = MatToBytes(matRaw);
}
void 	SetImage(int indexTool, uchar* uc, int image_rows, int image_cols, int image_type)
{
	m_matDst[indexTool] = Mat();
	m_matDst[indexTool] = BytesToMat(uc, image_rows, image_cols, image_type).clone();
	if (m_matDst[indexTool].type() == CV_8UC3)
		cvtColor(m_matDst[indexTool], m_matDst[indexTool], COLOR_BGR2GRAY);
}
extern "C" __declspec(dllexport) uchar * GetImage(int* rows, int* cols, int* Type)
{
	int rows_ = matRaw.rows;
	int cols_ = matRaw.cols;
	int Type_ = matRaw.type();
	*rows = rows_;
	*cols = cols_;
	*Type = Type_;
	
	return  MatToBytes(matRaw);
}
extern "C" __declspec(dllexport) uchar * GetImageCrop(  int* rows, int* cols,int* Type)
{
	
	
	int rows_ = matCrop.rows;
	int cols_ = matCrop.cols;
	int Type_ = matCrop.type();
	*rows = rows_;
	*cols = cols_;
	*Type = Type_;
	return  MatToBytes(matCrop);
}

extern "C" __declspec(dllexport) void SetDst(int indexTool, uchar * uc ,int image_rows, int image_cols,int image_type)
{
	
	SetImage( indexTool,  uc,  image_rows,  image_cols,  image_type);
	
}
extern "C" __declspec(dllexport) void SetSrc(uchar * uc, int image_rows, int image_cols, int image_type)
{
	matRaw = BytesToMat(uc,image_rows, image_cols, image_type);

}
#pragma region ScanCCD



std::map<int, Device> DeviceEnumerator::getVideoDevicesMap() {
	return getDevicesMap(CLSID_VideoInputDeviceCategory);
}

std::map<int, Device> DeviceEnumerator::getAudioDevicesMap() {
	return getDevicesMap(CLSID_AudioInputDeviceCategory);
}

// Returns a map of id and devices that can be used
std::map<int, Device> DeviceEnumerator::getDevicesMap(const GUID deviceClass)
{
	std::map<int, Device> deviceMap;

	HRESULT hr = CoInitialize(nullptr);
	if (FAILED(hr)) {
		return deviceMap; // Empty deviceMap as an error
	}

	// Create the System Device Enumerator
	ICreateDevEnum* pDevEnum;
	hr = CoCreateInstance(CLSID_SystemDeviceEnum, NULL, CLSCTX_INPROC_SERVER, IID_PPV_ARGS(&pDevEnum));

	// If succeeded, create an enumerator for the category
	IEnumMoniker* pEnum = NULL;
	if (SUCCEEDED(hr)) {
		hr = pDevEnum->CreateClassEnumerator(deviceClass, &pEnum, 0);
		if (hr == S_FALSE) {
			hr = VFW_E_NOT_FOUND;
		}
		pDevEnum->Release();
	}

	// Now we check if the enumerator creation succeeded
	int deviceId = -1;
	if (SUCCEEDED(hr)) {
		// Fill the map with id and friendly device name
		IMoniker* pMoniker = NULL;
		while (pEnum->Next(1, &pMoniker, NULL) == S_OK) {

			IPropertyBag* pPropBag;
			HRESULT hr = pMoniker->BindToStorage(0, 0, IID_PPV_ARGS(&pPropBag));
			if (FAILED(hr)) {
				pMoniker->Release();
				continue;
			}

			// Create variant to hold data
			VARIANT var;
			VariantInit(&var);

			std::string deviceName;
			std::string devicePath;

			// Read FriendlyName or Description
			hr = pPropBag->Read(L"Description", &var, 0); // Read description
			if (FAILED(hr)) {
				// If description fails, try with the friendly name
				hr = pPropBag->Read(L"FriendlyName", &var, 0);
			}
			// If still fails, continue with next device
			if (FAILED(hr)) {
				VariantClear(&var);
				continue;
			}
			// Convert to string
			else {
				deviceName = ConvertBSTRToMBS(var.bstrVal);
			}

			VariantClear(&var); // We clean the variable in order to read the next value

								// We try to read the DevicePath
			hr = pPropBag->Read(L"DevicePath", &var, 0);
			if (FAILED(hr)) {
				VariantClear(&var);
				continue; // If it fails we continue with next device
			}
			else {
				devicePath = ConvertBSTRToMBS(var.bstrVal);
			}

			// We populate the map
			deviceId++;
			Device currentDevice;
			currentDevice.id = deviceId;
			currentDevice.deviceName = deviceName;
			currentDevice.devicePath = devicePath;
			deviceMap[deviceId] = currentDevice;

		}
		pEnum->Release();
	}
	CoUninitialize();
	return deviceMap;
}

/*
This two methods were taken from
https://stackoverflow.com/questions/6284524/bstr-to-stdstring-stdwstring-and-vice-versa
*/

std::string DeviceEnumerator::ConvertBSTRToMBS(BSTR bstr)
{
	int wslen = ::SysStringLen(bstr);
	return ConvertWCSToMBS((wchar_t*)bstr, wslen);
}

std::string DeviceEnumerator::ConvertWCSToMBS(const wchar_t* pstr, long wslen)
{
	int len = ::WideCharToMultiByte(CP_ACP, 0, pstr, wslen, NULL, 0, NULL, NULL);

	std::string dblstr(len, '\0');
	len = ::WideCharToMultiByte(CP_ACP, 0 /* no flags */,
		pstr, wslen /* not necessary NULL-terminated */,
		&dblstr[0], len,
		NULL, NULL /* no default char */);

	return dblstr;
}
#pragma endregion
Pylon::String_t a="";
static const size_t c_maxCamerasToUse = 2;
DeviceInfoList_t devices;
System::String^ ScanBasler()
{
	PylonInitialize();
	// Get the transport layer factory.
	CTlFactory& tlFactory = CTlFactory::GetInstance();

	// Get all attached devices and exit application if no device is found.

	if (tlFactory.EnumerateDevices(devices) == 0)
	{
		return "";
	}
	CInstantCamera camera(CTlFactory::GetInstance().CreateFirstDevice());
	// Create an array of instant cameras for the found devices and avoid exceeding a maximum number of devices.
	//CInstantCameraArray cameras(min(devices.size(), c_maxCamerasToUse));
	std::string list1 = "";
	// Create and attach all Pylon Devices.
	for (size_t i = 0; i < devices.size(); ++i)
	{
		//cameras[i].Attach(tlFactory.CreateDevice(devices[i]));
		list1.append(devices[i].GetUserDefinedName()).append("$").append(devices[i].GetModelName()).append("$").append(devices[i].GetSerialNumber()).append("\n");
		// Print the model name of the camera.
		//cout << "Using device " << cameras[i].GetDeviceInfo().GetModelName() << endl;
	}

	return gcnew  System::String(list1.c_str());;
	
}
System::String^ ScanUsb()
{

	System::String^ ListCCD = "";
	DeviceEnumerator de;
	// Audio Devices
	std::map<int, Device> devices;
	std::string list1 = "";
	devices = de.getVideoDevicesMap();
	for (auto const& device : devices) {
		list1.append(device.second.deviceName).append("$").append(device.second.devicePath).append("\n");
		//.append(std::to_string(device.first)).append("$").
	}
	//ListCCD=System::String(list1.c_str()); //Marshal::PtrToStringAnsi(&list1, NULL);
	//Console::WriteLine(ListCCD);
	return gcnew  System::String(list1.c_str());;
}
System::String^ CCD::ScanCCD()
{
	System::String^ nameCCD="";
	switch (typeCCD)
	{
	case 1:
		nameCCD= ScanBasler();
		break;
	default: 
		nameCCD =ScanUsb();
		break;
	}
	return nameCCD;
}
bool ConnectBasler(int rowCCD, int colCCD, int index)
{
	if (index == -1)return false;
	try
	{
		
		//PylonInitialize();
	
		CTlFactory& tlFactory = CTlFactory::GetInstance();
		if (devices[index].GetFullName() != "")// đã nhận dc tên ccd
		{
			try
			{
				baslerGigE.Attach(tlFactory.CreateDevice(devices[index]));//kt quyền điều khiển
				baslerGigE.Open();
				GenApi::CBooleanPtr ptrAutoPacketSize = baslerGigE.GetStreamGrabberNodeMap().GetNode("AutoPacketSize");
				if (GenApi::IsWritable(ptrAutoPacketSize))
				{
					ptrAutoPacketSize->SetValue(true);
				}
				baslerGigE.Width.SetValue(colCCD);
				baslerGigE.Height.SetValue(rowCCD);
				int with = (int)baslerGigE.Width.GetMax();
				int height = (int)baslerGigE.Height.GetMax();
				baslerGigE.CenterX =true;
				baslerGigE.CenterX =true;
				baslerGigE.ExposureTimeAbs.SetValue(10);
				//_minOffsetX = (int)camera.OffsetX.GetMin();
				//baslerGigE.OffsetX.SetValue(_xCenter);
				//baslerGigE.OffsetY.SetValue(_yCenter);
				//baslerGigE.ExposureTime.SetValue(_exporsure);
				//camera.Gamma.SetValue(3.05);
				//camera.BlackLevel.SetValue(0);
				//Lamp(true);
				//IO(true);
				//minExplosure = (int)camera.ExposureTimeRaw.GetMin();
				//maxGain = (double)camera.Gamma.GetMax()*100.0;
				//maxSetX = (int)camera.OffsetX.GetMax();
				//maxSetY = (int)camera.OffsetY.GetMax();
				//WriteParaCCD();//set thong so ccd

				//	_StepExposure = (int)camera.ExposureTime.GetInc();

				//_maxblack = (int)camera.BlackLevel.GetMax();
				//_minblack = (int)camera.BlackLevel.GetMin();

				//_maxGain = (double)camera.Gain.GetMax();
				//_minGain = (double)camera.Gain.GetMin();

				//_maxExposure = (double)camera.ExposureTime.GetMax();
				//_minExposure = (double)camera.ExposureTime.GetMin();

				
				//_minOffsetY = (int)camera.OffsetY.GetMin();
				//_maxOffsetY = (int)camera.OffsetY.GetMax();
				//_maxWidth = (int)camera.Width.GetMax();
				//_minWidth = (int)camera.Width.GetMin();

				//_maxHeight = (int)camera.Height.GetMax();
				//_minHeight = (int)camera.Height.GetMin();
				////_StepGamma =(int) camera.Gamma.GetInc();
				//_StepWidth = (int)camera.Width.GetInc();
				//_StepHeight = (int)camera.Height.GetInc();

				//_StepOffsetX = (int)camera.OffsetX.GetInc();
				//_StepOffsetY = (int)camera.OffsetY.GetInc();
				baslerGigE.StartGrabbing();//Tao luong Doc anh

				fc.OutputPixelFormat = PixelType_Mono8;

				baslerGigE.RetrieveResult(-1, ptrGrabResult, TimeoutHandling_ThrowException);//Lay Data Camera SAU KHOẢNG THỜI GIAN SẼ THOÁT RA ,(NẾU GIÁ TRỊ BẰNG -1 KHÔNG THOÁT RA)
				if (ptrGrabResult->GrabSucceeded())
				{
					fc.Convert(image, ptrGrabResult);///Chuyen gia tri ma camera qua anh thu viện Pylon Balser
					matRaw = cv::Mat(ptrGrabResult->GetHeight(), ptrGrabResult->GetWidth(), CV_8UC1, (uint8_t*)image.GetBuffer(), Mat::AUTO_STEP);///convert anh thu vien pylon thanh Mat			
					
					

				}
				ptrGrabResult.Release();//Xoa data
				return true;
				//	


			}
			catch (GenICam::GenericException& e)
			{


				baslerGigE.StopGrabbing();
				baslerGigE.Close();
				baslerGigE.DetachDevice();

				//PylonTerminate();
			}
		}
	}
	catch (GenICam::GenericException& e)
	{

		baslerGigE.StopGrabbing();
		baslerGigE.Close();
		baslerGigE.DetachDevice();
		PylonTerminate();
	}
	return false;
}
bool	CCD::SetPara()
{
	return false;
}
bool ConnectUsb(int rowCCD, int colCCD, int index)
{
	camUSB.open(index);
	camUSB.set(CAP_PROP_FRAME_WIDTH, colCCD);
	camUSB.set(CAP_PROP_FRAME_HEIGHT, rowCCD);
	camUSB.set(CAP_PROP_AUTOFOCUS, 0);
	camUSB.set(CAP_PROP_FOCUS, 12);
	camUSB.set(CAP_PROP_AUTO_EXPOSURE, 0);
	camUSB.set(CAP_PROP_EXPOSURE, -11);
	

	if (camUSB.isOpened())
	{
		camUSB.read(matRaw);
		camUSB.read(matRaw);
		camUSB.read(matRaw);
		camUSB.read(matRaw);

		return true;
	}
	return false;
}
bool CCD::Connect( int rowCCD, int colCCD, int index)
{
	numERR = 0;
	IsErrCCD = false;
	switch (typeCCD)
	{
	case 1:return ConnectBasler(rowCCD, colCCD, index);
		break;
	default:return ConnectUsb(rowCCD, colCCD, index);
		break;
	}
	
}
void CCD::ReadCCD()
{
	double d1 = clock();
	switch (typeCCD)
	{
	case 1: 
		baslerGigE.RetrieveResult(-1, ptrGrabResult, TimeoutHandling_ThrowException);//Lay Data Camera SAU KHOẢNG THỜI GIAN SẼ THOÁT RA ,(NẾU GIÁ TRỊ BẰNG -1 KHÔNG THOÁT RA)
		if (ptrGrabResult->GrabSucceeded())
		{
			fc.Convert(image, ptrGrabResult);///Chuyen gia tri ma camera qua anh thu viện Pylon Balser
			matRaw = cv::Mat(ptrGrabResult->GetHeight(), ptrGrabResult->GetWidth(), CV_8UC1, (uint8_t*)image.GetBuffer(), Mat::AUTO_STEP);///convert anh thu vien pylon thanh Mat			
		}
		break;
	default:
		Mat raw = Mat();

		bool IsRead = camUSB.read(raw);
		//camUSB >> raw;
		matRaw = raw;
		if (!IsRead)
			IsErrCCD = true;

		matRaw = raw;
		break;

	}
	
	
	


	//camUSB.read(matRaw);
cycle = int(clock() - d1);
}
Mat equalizeBGRA(const Mat& img)
{
	Mat res(img.size(), img.type());
	Mat imgB(img.size(), CV_8UC1);
	Mat imgG(img.size(), CV_8UC1);
	Mat imgR(img.size(), CV_8UC1);
	Vec3b pixel;



	for (int r = 0; r < img.rows; r++)
	{
		for (int c = 0; c < img.cols; c++)
		{
			pixel = img.at<Vec3b>(r, c);
			imgB.at<uchar>(r, c) = pixel[0];
			imgG.at<uchar>(r, c) = pixel[1];
			imgR.at<uchar>(r, c) = pixel[2];
		}
	}

	equalizeHist(imgB, imgB);
	equalizeHist(imgG, imgG);
	equalizeHist(imgR, imgR);

	for (int r = 0; r < img.rows; r++)
	{
		for (int c = 0; c < img.cols; c++)
		{
			pixel = Vec3b(imgB.at<uchar>(r, c), imgG.at<uchar>(r, c), imgR.at<uchar>(r, c));
			res.at<Vec3b>(r, c) = pixel;
		}
	}

	return res;
}
//void CCD::ReadRaw(bool IsHist)
//{
//	double d1 = clock();
//	Mat raw = Mat();
//	camUSB.read(raw);
//
//	camUSB >> raw;
//	if (IsHist)
//		matRaw = equalizeBGRA(raw);
//	else
//		matRaw = raw;
//	if (matRaw.empty() || matRaw.cols == 0 || matRaw.rows == 0)
//		numERR++;
//
//	if (numERR > 5)
//	{
//		numERR = 0;
//		IsErrCCD = true;
//	}
//	cycle = int(clock() - d1);
//}


void CCD::CalHist()
{
	Mat src = matRaw.clone();
	
	//! [Load image]

	//! [Separate the image in 3 places ( B, G and R )]
	vector<Mat> bgr_planes;
	split(src, bgr_planes);
	//! [Separate the image in 3 places ( B, G and R )]

	//! [Establish the number of bins]
	int histSize = 256;
	//! [Establish the number of bins]

	//! [Set the ranges ( for B,G,R) )]
	float range[] = { 0, 256 }; //the upper boundary is exclusive
	const float* histRange[] = { range };
	//! [Set the ranges ( for B,G,R) )]

	//! [Set histogram param]
	bool uniform = true, accumulate = false;
	//! [Set histogram param]

	//! [Compute the histograms]
	Mat b_hist, g_hist, r_hist;
	calcHist(&bgr_planes[0], 1, 0, Mat(), b_hist, 1, &histSize, histRange, uniform, accumulate);
	calcHist(&bgr_planes[1], 1, 0, Mat(), g_hist, 1, &histSize, histRange, uniform, accumulate);
	calcHist(&bgr_planes[2], 1, 0, Mat(), r_hist, 1, &histSize, histRange, uniform, accumulate);
	//! [Compute the histograms]

	//! [Draw the histograms for B, G and R]
	int hist_w = 512, hist_h = 400;
	int bin_w = cvRound((double)hist_w / histSize);

	Mat histImage(hist_h, hist_w, CV_8UC3, Scalar(0, 0, 0));
	//! [Draw the histograms for B, G and R]

	//! [Normalize the result to ( 0, histImage.rows )]
	normalize(b_hist, b_hist, 0, histImage.rows, NORM_MINMAX, -1, Mat());
	normalize(g_hist, g_hist, 0, histImage.rows, NORM_MINMAX, -1, Mat());
	normalize(r_hist, r_hist, 0, histImage.rows, NORM_MINMAX, -1, Mat());
	//! [Normalize the result to ( 0, histImage.rows )]

	//! [Draw for each channel]
	for (int i = 1; i < histSize; i++)
	{
		line(histImage, cv::Point(bin_w * (i - 1), hist_h - cvRound(b_hist.at<float>(i - 1))),
			cv::Point(bin_w * (i), hist_h - cvRound(b_hist.at<float>(i))),
			Scalar(255, 0, 0), 2, 8, 0);
		line(histImage, cv::Point(bin_w * (i - 1), hist_h - cvRound(g_hist.at<float>(i - 1))),
			cv::Point(bin_w * (i), hist_h - cvRound(g_hist.at<float>(i))),
			Scalar(0, 255, 0), 2, 8, 0);
		line(histImage, cv::Point(bin_w * (i - 1), hist_h - cvRound(r_hist.at<float>(i - 1))),
			cv::Point(bin_w * (i), hist_h - cvRound(r_hist.at<float>(i))),
			Scalar(0, 0, 255), 2, 8, 0);
	}
	//! [Draw for each channel]

	//! [Display]
	imshow("Source image", equalizeBGRA(matRaw.clone()));
	imshow("calcHist Demo", histImage);


}
void CCD::DestroyAll()
{
	switch (typeCCD)
	{
	case 0 :
		camUSB.release();
		destroyAllWindows();
		break;
	case 1:
		baslerGigE.StopGrabbing();
		baslerGigE.Close();
		baslerGigE.DetachDevice();
		break;
	default:
		break;
	}
	
}
bool IsShow = false;
void CCD::ShowSetting()
{
	IsShow = !IsShow;
	
	if(IsShow)
camUSB.set(CAP_PROP_SETTINGS, 1);
	else
		destroyAllWindows();
}