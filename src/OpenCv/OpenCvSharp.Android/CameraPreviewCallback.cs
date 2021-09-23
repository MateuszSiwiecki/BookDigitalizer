using System;
using Android.Hardware;

namespace OpenCvSharp.Android
{
    //http://stackoverflow.com/questions/10635197/how-to-get-the-camerapreview-data-in-monodroid
    public class CameraPreviewCallback : Java.Lang.Object, Camera.IPreviewCallback
    {
        public event EventHandler<PreviewUpdatedEventArgs> PreviewUpdated;

        public void OnPreviewFrame(byte[] data, Camera camera)
        {
            PreviewUpdated.Invoke(this, new PreviewUpdatedEventArgs(data, camera));
        }
    }

    public class PreviewUpdatedEventArgs
    {
        public byte[] Buffer;
        public Camera Camera;
        
        public PreviewUpdatedEventArgs(byte[] data, Camera camera)
        {
            Buffer = data;
            Camera = camera;
        }
    }
}
