
#include "pch.h"
#include <pylon/PylonIncludes.h>
#include <pylon/gige/BaslerGigEInstantCamera.h>
typedef Pylon::CBaslerGigEInstantCamera Camera_t;
typedef Camera_t::GrabResultPtr_t GrabResultPtr_t;

using namespace GenApi;
using namespace Basler_GigECameraParams;
using namespace Pylon;
#include <opencv2/opencv.hpp>
#include <opencv2/highgui/highgui_c.h>
#include <opencv2/imgproc/imgproc_c.h>
#include <opencv2/imgproc/types_c.h>

#include <direct.h>
#include <iostream>
#include <fstream>

#include <stdio.h>

#include <process.h>         // needed for _beginthread()
#include <ctime>

#include <sys/types.h>
#include <sys/stat.h>
#include <stdio.h>
#include <stdlib.h>
#include <algorithm>
#define ENUM_TO_STR(ENUM) std::string(#ENUM)
#include <ctime>
#using <System.Windows.Forms.dll> 
#using <System.Drawing.dll> 
//#include "zbar.h"
#include <string>
#include <iostream>
using namespace cv;
using namespace std;
using namespace System;
using namespace System::Threading;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;

namespace CvPlus {
	
	extern CDeviceInfo nameBasler;
	extern Camera_t baslerGigE;
	extern CGrabResultPtr ptrGrabResult;
	extern CPylonImage image;/////anh output
	extern CImageFormatConverter fc;///anh convert
	Mat BitmapToMat(System::Drawing::Bitmap^ bitmap);
	Bitmap^ MatToBitmap(Mat img);
	extern cv::VideoCapture camUSB;

	 extern uchar* ucRaw;
	extern cv::Mat matTemp, matRaw, matResult, matRsTemp,matCrop;
	extern cv::Mat m_matSrc;
	extern vector<cv::Mat> m_matDst;
	Mat CropImage(Mat matCrop, Rect rect);
	
	public ref  class Common
	{
	//public:Byte* ReturnRaw();
	public:	Bitmap^	GetImageRaw();
	public:	Bitmap^ GetImageRsTemp();
	public:	  Bitmap^ GetImageResult();
	public:void	BitmapSrc(Bitmap^ bm);
	public:void	BitmapDst(Bitmap^ bm, int ix);
	public:void  BitmapEdit(Bitmap^ bm);
	public:  void LoadSrc(System::String^ path);
	public:  void LoadDst(System::String^ path);
		 
	};

	 
}