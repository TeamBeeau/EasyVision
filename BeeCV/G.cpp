
#include "G.h"
using  namespace CvPlus;
namespace CvPlus
{
	
	CDeviceInfo nameBasler;
	Camera_t baslerGigE;
	CGrabResultPtr ptrGrabResult;
	CPylonImage image;/////anh output
	CImageFormatConverter fc;///anh convert
	
	cv::Mat matCrop;
	cv::VideoCapture camUSB;
	 cv::Mat matTemp, matRaw, matResult, matRsTemp;
	 cv::Mat m_matSrc;
	vector< cv::Mat> m_matDst;
	 uchar* ucRaw; uchar* ucCrop;
	string _toString(System::String^ STR)
	{
		char cStr[1000] = { 0 };
		sprintf(cStr, "%s", STR);
		std::string s(cStr);
		return s;
	}
	
	Mat CropImage(Mat matCrop, Rect rect)
	{
		return matCrop(rect);
	}
	void Common::BitmapSrc(Bitmap^ bm)
	{
		matRaw = BitmapToMat(bm);
	}
	void Common::BitmapEdit(Bitmap^ bm)
	{
		m_matSrc= BitmapToMat(bm);
	}
	void Common::BitmapDst(Bitmap^ bm,int ix)
	{
		m_matDst[ix]  = BitmapToMat(bm);
	}
	Bitmap^ Common::GetImageRsTemp()
	{
		return MatToBitmap(matRsTemp);
	}
	Bitmap^ Common::GetImageResult()
	{
		return MatToBitmap(matResult);
	}
	Bitmap^ Common::GetImageRaw()
	{
		return MatToBitmap(matRaw);
	}
	void Common::LoadSrc(System::String^ path)
	{
		matRaw = cv::imread(_toString(path), ImreadModes::IMREAD_COLOR);
	}
	void Common::LoadDst(System::String^ path)
	{
		matTemp = cv::imread(_toString(path), ImreadModes::IMREAD_GRAYSCALE);
		///int a = matTemp.cols;
		//cv::imshow("a", matTemp);
	}
	

	Mat  BitmapToMat(System::Drawing::Bitmap^ bitmap)
	{
		IplImage* tmp = NULL;

		System::Drawing::Imaging::BitmapData^ bmData = bitmap->LockBits(System::Drawing::Rectangle(0, 0, bitmap->Width, bitmap->Height), System::Drawing::Imaging::ImageLockMode::ReadWrite, bitmap->PixelFormat);
		if (bitmap->PixelFormat == System::Drawing::Imaging::PixelFormat::Format8bppIndexed)
		{
			tmp = cvCreateImage(cvSize(bitmap->Width, bitmap->Height), IPL_DEPTH_8U, 1);
			tmp->imageData = (char*)bmData->Scan0.ToPointer();
		}

		else if (bitmap->PixelFormat == System::Drawing::Imaging::PixelFormat::Format24bppRgb)
		{
			tmp = cvCreateImage(cvSize(bitmap->Width, bitmap->Height), IPL_DEPTH_8U, 3);
			tmp->imageData = (char*)bmData->Scan0.ToPointer();
		}

		bitmap->UnlockBits(bmData);

		return cvarrToMat(tmp);
	}
	Bitmap^ MatToBitmap(Mat img)
	{


		if (img.data == nullptr)
			return nullptr;
		if (img.type() != CV_8UC3)
		{
			//throw gcnew NotSupportedException("Only images of type CV_8UC3 are supported for conversion to Bitmap");
		}

		//create the bitmap and get the pointer to the data
		Bitmap^ bmpimg = gcnew Bitmap(img.cols, img.rows, PixelFormat::Format24bppRgb);

		BitmapData^ data = bmpimg->LockBits(System::Drawing::Rectangle(0, 0, img.cols, img.rows), ImageLockMode::WriteOnly, PixelFormat::Format24bppRgb);

		byte* dstData = reinterpret_cast<byte*>(data->Scan0.ToPointer());

		unsigned char* srcData = img.data;

		for (int row = 0; row < data->Height; ++row)
		{
			memcpy(reinterpret_cast<void*>(&dstData[row * data->Stride]), reinterpret_cast<void*>(&srcData[row * img.step]), img.cols * img.channels());
		}

		bmpimg->UnlockBits(data);
		delete(data);
		img.release();
		return bmpimg;
	}
}