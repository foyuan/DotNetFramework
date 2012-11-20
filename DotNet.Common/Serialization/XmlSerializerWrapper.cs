/********************************************************************************
 * Copyright (C) Newegg Corporation. All rights reserved.
 * 
 * Author: Allen Wang(Allen.G.Wang@newegg.com) 
 * Create Date: 5/7/2009
 * Description:
 *          
 * Revision History:
 *      Date         Author               Description
 * 
*********************************************************************************/
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace DotNet.Common.Serialization
{
	/// <summary>
	/// Xml���л���
	/// </summary>
	public class XmlSerializerWrapper : SerializerBase
	{
		#region [ Fields ]

		private static ISerializer serializer = new XmlSerializerWrapper();

		#endregion

		#region [ Methods ]

		/// <summary>
		/// ��ǰʵ����
		/// </summary>
		public static ISerializer GetInstance()
		{
			return serializer;
		}

		/// <summary>
		/// �Ѷ���ת���ɶ��������ݡ�
		/// </summary>
		/// <typeparam name="T">Ҫת���ɶ��������ݶ�������͡�</typeparam>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
		/// <param name="encoding">���������ݱ����ʽ��</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>���������ݡ�</returns>
		public override byte[] ToBinary(object obj, Encoding encoding, Type[] extraTypes)
		{
			byte[] bytes = null;

			if (obj != null)
			{
				XmlSerializer serializer = new XmlSerializer(obj.GetType(), extraTypes);

				using (MemoryStream ms = new MemoryStream())
				{
					using (XmlTextWriter xtw = new XmlTextWriter(ms, encoding))
					{
						serializer.Serialize(xtw, obj);
						ms.Position = 0;
						bytes = ms.ToArray();
					}
				}
			}
			else
			{
				bytes = new byte[] { };
			}

			return bytes;
		}

		/// <summary>
		/// ��֧�ִ����л���ʽ��
		/// </summary>
		/// <param name="bytes">Ҫת���ɵĶ������͡�</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		public override object FromBinary(byte[] bytes, Type[] extraTypes)
		{
			throw new NotSupportedException();
		}

        /// <summary>
        /// �Ѷ��������ݷ����л��ɶ���
        /// </summary>
		/// <param name="type">Ҫת���ɵĶ������͡�</param>
		/// <param name="bytes">����������</param>
        /// <param name="encoding">���롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
        /// <returns>����</returns>
		public override object FromBinary(Type type, byte[] bytes, Encoding encoding, Type[] extraTypes)
        {
            object ret = null;
			if (bytes == null || bytes.Length <= 0)
            {
                return ret;
            }

			using (MemoryStream stream = new MemoryStream(bytes))
            {
                XmlSerializer serializer = new XmlSerializer(type, extraTypes);
                ret = serializer.Deserialize(stream);
            }

            return ret;
		}

		#endregion
	}
}