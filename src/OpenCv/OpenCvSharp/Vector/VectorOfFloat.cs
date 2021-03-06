using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCvSharp.Util;

namespace OpenCvSharp
{
    /// <summary>
    /// 
    /// </summary>
    public class VectorOfFloat : DisposableCvObject, IStdVector<float>
    {
        /// <summary>
        /// 
        /// </summary>
        public VectorOfFloat()
        {
            ptr = NativeMethods.vector_float_new1();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        public VectorOfFloat(int size)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException(nameof(size));
            ptr = NativeMethods.vector_float_new2(new IntPtr(size));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public VectorOfFloat(IEnumerable<float> data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));
            float[] array = EnumerableEx.ToArray(data);
            ptr = NativeMethods.vector_float_new3(array, new IntPtr(array.Length));
        }

        /// <summary>
        /// Releases unmanaged resources
        /// </summary>
        protected override void DisposeUnmanaged()
        {
            NativeMethods.vector_float_delete(ptr);
            base.DisposeUnmanaged();
        }

        /// <summary>
        /// vector.size()
        /// </summary>
        public int Size
        {
            get { return NativeMethods.vector_float_getSize(ptr).ToInt32(); }
        }

        /// <summary>
        /// &amp;vector[0]
        /// </summary>
        public IntPtr ElemPtr
        {
            get { return NativeMethods.vector_float_getPointer(ptr); }
        }

        /// <summary>
        /// Converts std::vector to managed array
        /// </summary>
        /// <returns></returns>
        public float[] ToArray()
        {
            int size = Size;
            if (size == 0)
            {
                return new float[0];
            }
            float[] dst = new float[size];
            Marshal.Copy(ElemPtr, dst, 0, dst.Length);
            return dst;
        }
    }
}
