using Heroje_Debug_Tool.SubForm;
using System.Drawing;

namespace BeeDevice
{
	public struct ReadingPageParaStu
	{
		public ProtocolExtraDataStu ProtocolExtraData;

		public uint DecodeTime;

		public int BarcodeLen;

		public string barcode_type;

		public string barcode_str;

		public string FrameRate;

		public int TrigCount;

		public Image ImageShow;

		public DeviceConnectForm.Polygon BarCodeRegion;
	}
}
