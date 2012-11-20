using System;
using System.IO;
using System.Text;
using System.Xml;

using DotNet.Common.Utility;

namespace DotNet.Common.Serialization
{
    /// <summary>
    /// Xml���л����ࡣ
    /// </summary>
	public class SerializerBase : ISerializer
	{
		#region [ ToFile ]

		/// <summary>
		/// �Ѷ������л�ΪXml�ı��󣬱��浽Xml�ļ��С�
		/// </summary>
		/// <typeparam name="T">Ҫת����Xml�ı���������͡�</typeparam>
		/// <param name="obj">Ҫת����Xml�ı�����</param>
		/// <param name="fileName">Xml�ļ�����</param>
		/// <returns>�������ɹ����浽Xml�ļ��з��� <b>true</b>, ��֮���� <b>false</b>��</returns>
		public bool ToFile<T>(T obj, string fileName) where T : class, new()
		{
			return ToFile<T>(obj, fileName, Encoding.UTF8);
		}

		/// <summary>
		/// �Ѷ������л�ΪXml�ı��󣬱��浽Xml�ļ��С�
		/// </summary>
		/// <typeparam name="T">Ҫת����Xml�ı���������͡�</typeparam>
		/// <param name="obj">Ҫת����Xml�ı�����</param>
		/// <param name="fileName">Xml�ļ�����</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>�������ɹ����浽Xml�ļ��з��� <b>true</b>, ��֮���� <b>false</b>��</returns>
		public bool ToFile<T>(T obj, string fileName, Type[] extraTypes) where T : class, new()
		{
			return ToFile<T>(obj, fileName, Encoding.UTF8, extraTypes);
		}

		/// <summary>
		/// �Ѷ������л�ΪXml�ı��󣬱��浽Xml�ļ��С�
		/// </summary>
		/// <typeparam name="T">Ҫת����Xml�ı���������͡�</typeparam>
		/// <param name="obj">Ҫת����Xml�ı�����</param>
		/// <param name="fileName">Xml�ļ�����</param>
		/// <param name="encoding">�ļ����롣</param>
		/// <returns>�������ɹ����浽Xml�ļ��з��� <b>true</b>, ��֮���� <b>false</b>��</returns>
		public bool ToFile<T>(T obj, string fileName, Encoding encoding) where T : class, new()
		{
			return ToFile<T>(obj, fileName, encoding, new Type[] { });
		}

		/// <summary>
		/// �Ѷ������л�ΪXml�ı��󣬱��浽Xml�ļ��С�
		/// </summary>
		/// <typeparam name="T">Ҫת����Xml�ı���������͡�</typeparam>
		/// <param name="obj">Ҫת����Xml�ı�����</param>
		/// <param name="fileName">Xml�ļ�����</param>
		/// <param name="encoding">�ļ����롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>�������ɹ����浽Xml�ļ��з��� <b>true</b>, ��֮���� <b>false</b>��</returns>
		public virtual bool ToFile<T>(T obj, string fileName, Encoding encoding, Type[] extraTypes) where T : class, new()
		{
			bool saved = true;

			try
			{
				string serializedString = ToSerializedString(obj, encoding, extraTypes);
				if (!StringHelper.IsEmpty(serializedString))
				{
					XmlDocument doc = new XmlDocument();
					doc.LoadXml(serializedString);
					doc.Save(fileName);
				}

				saved = true;
			}
			catch
			{
				saved = false;
			}

			return saved;
		}

		#endregion

		#region [ ToSerializedString ]

		/// <summary>
		/// ���������л�ΪUTF-8��ʽ���ı��� 
		/// </summary>
		/// <param name="obj">Ҫ���л�Ϊ�ı��Ķ���</param>
		/// <returns>
		/// ��� <paramref name="obj"/> �ǿ����ã����� <seealso cref="String.Empty"/>, ��֮�������л��ı���
		/// </returns>
		public string ToSerializedString(object obj)
        {
			return ToSerializedString(obj, Encoding.UTF8);
        }

		/// <summary>
		/// ���������л�ΪUTF-8��ʽ���ı��� 
		/// </summary>
		/// <param name="obj">Ҫ���л�Ϊ�ı��Ķ���</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>
		/// ��� <paramref name="obj"/> �ǿ����ã����� <seealso cref="String.Empty"/>, ��֮�������л��ı���
		/// </returns>
		public string ToSerializedString(object obj, Type[] extraTypes)
		{
			return ToSerializedString(obj, Encoding.UTF8, extraTypes);
		}

		/// <summary>
		/// ���������л�Ϊָ�������ʽ���ı��� 
		/// </summary>
		/// <param name="obj">Ҫ���л�Ϊ�ı��Ķ���</param>
		/// <param name="encoding">�ı������ʽ�����Ϊ��������Ĭ��ΪUTF-8�����ʽ��</param>
		/// <returns>
		/// ��� <paramref name="obj"/> �ǿ����ã����� <seealso cref="String.Empty"/>, ��֮�������л��ı���
		/// </returns>
		public string ToSerializedString(object obj, Encoding encoding)
        {
			return ToSerializedString(obj, encoding, new Type[] { });
		}

		/// <summary>
		/// ���������л�Ϊָ�������ʽ���ı��� 
		/// </summary>
		/// <param name="obj">Ҫ���л�Ϊ�ı��Ķ���</param>
		/// <param name="encoding">�ı������ʽ�����Ϊ��������Ĭ��ΪUTF-8�����ʽ��</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>
		/// ��� <paramref name="obj"/> �ǿ����ã����� <seealso cref="String.Empty"/>, ��֮�������л��ı���
		/// </returns>
		public virtual string ToSerializedString(object obj, Encoding encoding, Type[] extraTypes)
		{
			byte[] bytes = ToBinary(obj, encoding, extraTypes);
			return encoding.GetString(bytes).TrimStart();
		}

		#endregion

		#region [ ToBinary ]

		/// <summary>
		/// �Ѷ���ת���ɶ��������ݡ�
		/// </summary>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
		/// <returns>���������ݡ�</returns>
		public byte[] ToBinary(object obj)
        {
			return ToBinary(obj, Encoding.UTF8);
        }

		/// <summary>
		/// �Ѷ���ת���ɶ��������ݡ�
		/// </summary>
		/// <typeparam name="T">Ҫת���ɶ��������ݶ�������͡�</typeparam>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>���������ݡ�</returns>
		public byte[] ToBinary(object obj, Type[] extraTypes)
		{
			return ToBinary(obj, Encoding.UTF8, extraTypes);
		}

		/// <summary>
		/// �Ѷ���ת���ɶ��������ݡ�
		/// </summary>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
		/// <param name="encoding">Xml�ı����롣</param>
		/// <returns>���������ݡ�</returns>
		public byte[] ToBinary(object obj, Encoding encoding)
		{
			return ToBinary(obj, encoding, new Type[] { });
		}

		/// <summary>
		/// �Ѷ���ת���ɶ��������ݡ�
		/// </summary>
		/// <typeparam name="T">Ҫת���ɶ��������ݶ�������͡�</typeparam>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
		/// <param name="encoding">���������ݱ����ʽ��</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>���������ݡ�</returns>
		public virtual byte[] ToBinary(object obj, Encoding encoding, Type[] extraTypes)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region [ FromFile ]

		/// <summary>
		/// ��xml�ļ������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="fileName">xml�ļ���</param>
		/// <returns>����</returns>
		/// <remarks>
		/// Ĭ�ϱ���ΪUTF8��
		/// </remarks>
		public T FromFile<T>(string fileName) where T : class, new()
		{
            return FromFile<T>(fileName, Encoding.UTF8);
		}

		/// <summary>
		/// ��xml�ļ������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="fileName">xml�ļ���</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		/// <remarks>
		/// Ĭ�ϱ���ΪUTF8��
		/// </remarks>
		public T FromFile<T>(string fileName, Type[] extraTypes) where T : class, new()
		{
			return FromFile<T>(fileName, Encoding.UTF8, extraTypes);
		}

        /// <summary>
        /// ��xml�ļ������л��ɶ���
        /// </summary>
        /// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
        /// <param name="fileName">xml�ļ���</param>
        /// <param name="encoding">�ļ����롣</param>
        /// <returns>����</returns>
        public T FromFile<T>(string fileName, Encoding encoding) where T : class, new()
        {
			return FromFile<T>(fileName, encoding, new Type[] { });
		}

		/// <summary>
		/// ��xml�ļ������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="fileName">xml�ļ���</param>
		/// <param name="encoding">�ļ������ʽ��</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		public T FromFile<T>(string fileName, Encoding encoding, Type[] extraTypes) where T : class, new()
		{
            T ret = default(T);
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[0];
                BinaryReader r = new BinaryReader(fs, encoding);
                r.BaseStream.Seek(0, SeekOrigin.Begin);    //���ļ�ָ�����õ��ļ���
                bytes = r.ReadBytes((int)r.BaseStream.Length);

                ret = (T)FromBinary<T>(bytes, encoding, extraTypes);
            }

            return ret;
        }

		#endregion

		#region [ FromSerializedString ]

		/// <summary>
        /// ��xml�ı������л��ɶ���
        /// </summary>
        /// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
        /// <param name="xml">xml�ı�</param>
        /// <returns>����</returns>
		public T FromSerializedString<T>(string serializedString) where T : class, new()
        {
			return FromSerializedString<T>(serializedString, Encoding.UTF8);
        }

		/// <summary>
		/// ���ı������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="serializedString">���л����ı���</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		/// <remarks>
		/// Ĭ�ϱ���ΪUTF8��
		/// </remarks>
		public T FromSerializedString<T>(string serializedString, Type[] extraTypes) where T : class, new()
		{
			return FromSerializedString<T>(serializedString, Encoding.UTF8, extraTypes);
		}

		/// <summary>
		/// ��xml�ı������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="serializedString">xml�ı�</param>
		/// <param name="encoding">�ı����롣</param>
		/// <returns>����</returns>
		public T FromSerializedString<T>(string serializedString, Encoding encoding) where T : class, new()
		{
			return FromSerializedString<T>(serializedString, encoding, new Type[] { });
		}

		/// <summary>
		/// ���ı������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="serializedString">���л����ı���</param>
		/// <param name="encoding">xml�ı����롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		public virtual T FromSerializedString<T>(string serializedString, Encoding encoding, Type[] extraTypes) where T : class, new()
		{
			T ret = default(T);
			if (StringHelper.IsEmpty(serializedString))
			{
				return ret;
			}

			byte[] bytes = encoding.GetBytes(serializedString);

			return FromBinary<T>(bytes, encoding, extraTypes);
		}

		#endregion

		#region [ FromBinary ]

		/// <summary>
        /// �Ѷ��������ݷ����л��ɶ���
        /// </summary>
        /// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
        /// <param name="bytes">����������</param>
        /// <returns>����</returns>
        public T FromBinary<T>(byte[] bytes) where T : class, new()
        {
			return FromBinary<T>(bytes, Encoding.UTF8, new Type[] { });
        }

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="bytes">����������</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		public T FromBinary<T>(byte[] bytes, Type[] extraTypes) where T : class, new()
		{
			return FromBinary<T>(bytes, Encoding.UTF8, extraTypes);
		}

        /// <summary>
        /// �Ѷ��������ݷ����л��ɶ���
        /// </summary>
        /// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
        /// <param name="bytes">����������</param>
        /// <param name="encoding">���롣</param>
        /// <returns>����</returns>
        public T FromBinary<T>(byte[] bytes, Encoding encoding) where T : class, new()
        {
			return FromBinary<T>(bytes, encoding, new Type[] { });
        }

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="bytes">����������</param>
		/// <param name="encoding">���롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		public T FromBinary<T>(byte[] bytes, Encoding encoding, Type[] extraTypes) where T : class, new()
		{
			return (T)FromBinary(typeof(T), bytes, encoding, extraTypes); 
		}

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="bytes">����������</param>
		/// <returns>����</returns>
		public object FromBinary(byte[] bytes)
		{
			return FromBinary(null, bytes, Encoding.UTF8);
		}

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="bytes">����������</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		public virtual object FromBinary(byte[] bytes, Type[] extraTypes)
		{
			return FromBinary(null, bytes, Encoding.UTF8, extraTypes);
		}

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="type">Ҫת���ɵĶ������͡�</param>
		/// <param name="bytes">����������</param>
		/// <returns>����</returns>
		public object FromBinary(Type type, byte[] bytes)
		{
            return FromBinary(type, bytes, Encoding.UTF8);
		}

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="type">Ҫת���ɵĶ������͡�</param>
		/// <param name="bytes">����������</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		public object FromBinary(Type type, byte[] bytes, Type[] extraTypes)
		{
			return FromBinary(type, bytes, Encoding.UTF8, extraTypes);
		}

        /// <summary>
        /// �Ѷ��������ݷ����л��ɶ���
        /// </summary>
        /// <param name="type">Ҫת���ɵĶ������͡�</param>
        /// <param name="bytes">����������</param>
        /// <param name="encoding">���롣</param>
        /// <returns>����</returns>
        public object FromBinary(Type type, byte[] bytes, Encoding encoding)
        {
			return FromBinary(type, bytes, encoding, new Type[] { });
		}

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="type">Ҫת���ɵĶ������͡�</param>
		/// <param name="bytes">����������</param>
		/// <param name="encoding">���롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		public virtual object FromBinary(Type type, byte[] bytes, Encoding encoding, Type[] extraTypes)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}