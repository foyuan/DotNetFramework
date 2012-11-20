/********************************************************************************
 * Copyright (C) Newegg Corporation. All rights reserved.
 * 
 * Author: Allen Wang(Allen.G.Wang@newegg.com) 
 * Create Date: 12/23/2008 
 * Description:
 *          
 * Revision History:
 *      Date         Author               Description
 * 
*********************************************************************************/
using System;
using System.Text;

namespace DotNet.Common.Serialization
{
	/// <summary>
	/// ���л�����
	/// </summary>
	public interface ISerializer
	{
		#region [ ToFile ]

		/// <summary>
		/// �Ѷ������л�ΪXml�ı��󣬱��浽Xml�ļ��С�
		/// </summary>
		/// <typeparam name="T">Ҫת����Xml�ı���������͡�</typeparam>
		/// <param name="obj">Ҫת����Xml�ı�����</param>
		/// <param name="fileName">Xml�ļ�����</param>
		/// <returns>�������ɹ����浽Xml�ļ��з��� <b>true</b>, ��֮���� <b>false</b>��</returns>
		bool ToFile<T>(T obj, string fileName) where T : class, new();

		/// <summary>
		/// �Ѷ������л�ΪXml�ı��󣬱��浽Xml�ļ��С�
		/// </summary>
		/// <typeparam name="T">Ҫת����Xml�ı���������͡�</typeparam>
		/// <param name="obj">Ҫת����Xml�ı�����</param>
		/// <param name="fileName">Xml�ļ�����</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>�������ɹ����浽Xml�ļ��з��� <b>true</b>, ��֮���� <b>false</b>��</returns>
		bool ToFile<T>(T obj, string fileName, Type[] extraTypes) where T : class, new();

		/// <summary>
		/// �Ѷ������л�ΪXml�ı��󣬱��浽Xml�ļ��С�
		/// </summary>
		/// <typeparam name="T">Ҫת����Xml�ı���������͡�</typeparam>
		/// <param name="obj">Ҫת����Xml�ı�����</param>
		/// <param name="fileName">Xml�ļ�����</param>
		/// <param name="encoding">�ļ����롣</param>
		/// <returns>�������ɹ����浽Xml�ļ��з��� <b>true</b>, ��֮���� <b>false</b>��</returns>
		bool ToFile<T>(T obj, string fileName, Encoding encoding) where T : class, new();

		/// <summary>
		/// �Ѷ������л�ΪXml�ı��󣬱��浽Xml�ļ��С�
		/// </summary>
		/// <typeparam name="T">Ҫת����Xml�ı���������͡�</typeparam>
		/// <param name="obj">Ҫת����Xml�ı�����</param>
		/// <param name="fileName">Xml�ļ�����</param>
		/// <param name="encoding">�ļ����롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>�������ɹ����浽Xml�ļ��з��� <b>true</b>, ��֮���� <b>false</b>��</returns>
		bool ToFile<T>(T obj, string fileName, Encoding encoding, Type[] extraTypes) where T : class, new();

		#endregion

		#region [ ToSerializedString ]

		/// <summary>
		/// ���������л�ΪUTF-8��ʽ���ı��� 
		/// </summary>
		/// <param name="obj">Ҫ���л�Ϊ�ı��Ķ���</param>
		/// <returns>
		/// ��� <paramref name="obj"/> �ǿ����ã����� <seealso cref="String.Empty"/>, ��֮�������л��ı���
		/// </returns>
		string ToSerializedString(object obj);

		/// <summary>
		/// ���������л�ΪUTF-8��ʽ���ı��� 
		/// </summary>
		/// <param name="obj">Ҫ���л�Ϊ�ı��Ķ���</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>
		/// ��� <paramref name="obj"/> �ǿ����ã����� <seealso cref="String.Empty"/>, ��֮�������л��ı���
		/// </returns>
		string ToSerializedString(object obj, Type[] extraTypes);

		/// <summary>
		/// ���������л�Ϊָ�������ʽ���ı��� 
		/// </summary>
		/// <param name="obj">Ҫ���л�Ϊ�ı��Ķ���</param>
		/// <param name="encoding">�ı������ʽ�����Ϊ��������Ĭ��ΪUTF-8�����ʽ��</param>
		/// <returns>
		/// ��� <paramref name="obj"/> �ǿ����ã����� <seealso cref="String.Empty"/>, ��֮�������л��ı���
		/// </returns>
		string ToSerializedString(object obj, Encoding encoding);

		/// <summary>
		/// ���������л�Ϊָ�������ʽ���ı��� 
		/// </summary>
		/// <param name="obj">Ҫ���л�Ϊ�ı��Ķ���</param>
		/// <param name="encoding">�ı������ʽ�����Ϊ��������Ĭ��ΪUTF-8�����ʽ��</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>
		/// ��� <paramref name="obj"/> �ǿ����ã����� <seealso cref="String.Empty"/>, ��֮�������л��ı���
		/// </returns>
		string ToSerializedString(object obj, Encoding encoding, Type[] extraTypes);

		#endregion

		#region [ ToBinary ]

		/// <summary>
        /// �Ѷ���ת���ɶ��������ݡ�
        /// </summary>
        /// <typeparam name="T">Ҫת���ɶ��������ݶ�������͡�</typeparam>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
        /// <returns>���������ݡ�</returns>
		byte[] ToBinary(object obj);

		/// <summary>
		/// �Ѷ���ת���ɶ��������ݡ�
		/// </summary>
		/// <typeparam name="T">Ҫת���ɶ��������ݶ�������͡�</typeparam>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>���������ݡ�</returns>
		byte[] ToBinary(object obj, Type[] extraTypes);

		/// <summary>
		/// �Ѷ���ת���ɶ��������ݡ�
		/// </summary>
		/// <typeparam name="T">Ҫת���ɶ��������ݶ�������͡�</typeparam>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
		/// <param name="encoding">���������ݱ����ʽ��</param>
		/// <returns>���������ݡ�</returns>
		byte[] ToBinary(object obj, Encoding encoding);

		/// <summary>
		/// �Ѷ���ת���ɶ��������ݡ�
		/// </summary>
		/// <typeparam name="T">Ҫת���ɶ��������ݶ�������͡�</typeparam>
		/// <param name="obj">Ҫת���ɶ��������ݵĶ���</param>
		/// <param name="encoding">���������ݱ����ʽ��</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>���������ݡ�</returns>
		byte[] ToBinary(object obj, Encoding encoding, Type[] extraTypes);

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
		T FromFile<T>(string fileName) where T : class, new();

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
		T FromFile<T>(string fileName, Type[] extraTypes) where T : class, new();

		/// <summary>
		/// ��xml�ļ������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="fileName">xml�ļ���</param>
		/// <param name="encoding">�ļ������ʽ��</param>
		/// <returns>����</returns>
        T FromFile<T>(string fileName, Encoding encoding) where T : class, new();

		/// <summary>
		/// ��xml�ļ������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="fileName">xml�ļ���</param>
		/// <param name="encoding">�ļ������ʽ��</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		T FromFile<T>(string fileName, Encoding encoding, Type[] extraTypes) where T : class, new();

		#endregion

		#region [ FromSerializedString ]

		/// <summary>
        /// ���ı������л��ɶ���
        /// </summary>
        /// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="serializedString">���л����ı���</param>
        /// <returns>����</returns>
		/// <remarks>
		/// Ĭ�ϱ���ΪUTF8��
		/// </remarks>
		T FromSerializedString<T>(string serializedString) where T : class, new();

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
		T FromSerializedString<T>(string serializedString, Type[] extraTypes) where T : class, new();

		/// <summary>
		/// ���ı������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="serializedString">���л����ı���</param>
		/// <param name="encoding">xml�ı����롣</param>
		/// <returns>����</returns>
		T FromSerializedString<T>(string serializedString, Encoding encoding) where T : class, new();

		/// <summary>
		/// ���ı������л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="serializedString">���л����ı���</param>
		/// <param name="encoding">xml�ı����롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		T FromSerializedString<T>(string serializedString, Encoding encoding, Type[] extraTypes) where T : class, new();

		#endregion

		#region [ FromBinary ]

		/// <summary>
        /// �Ѷ��������ݷ����л��ɶ���
        /// </summary>
        /// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
        /// <param name="bytes">����������</param>
        /// <returns>����</returns>
        T FromBinary<T>(byte[] bytes) where T : class, new();

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="bytes">����������</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		T FromBinary<T>(byte[] bytes, Type[] extraTypes) where T : class, new();

        /// <summary>
        /// �Ѷ��������ݷ����л��ɶ���
        /// </summary>
        /// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
        /// <param name="bytes">����������</param>
        /// <param name="encoding">���롣</param>
        /// <returns>����</returns>
        T FromBinary<T>(byte[] bytes, Encoding encoding) where T : class, new();

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <typeparam name="T">Ҫת���ɵĶ������͡�</typeparam>
		/// <param name="bytes">����������</param>
		/// <param name="encoding">���롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		T FromBinary<T>(byte[] bytes, Encoding encoding, Type[] extraTypes) where T : class, new();

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="bytes">����������</param>
		/// <returns>����</returns>
		object FromBinary(byte[] bytes);

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="bytes">����������</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		object FromBinary(byte[] bytes, Type[] extraTypes);

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="type">Ҫת���ɵĶ������͡�</param>
		/// <param name="bytes">����������</param>
		/// <returns>����</returns>
		object FromBinary(Type type, byte[] bytes);

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="type">Ҫת���ɵĶ������͡�</param>
		/// <param name="bytes">����������</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		object FromBinary(Type type, byte[] bytes, Type[] extraTypes);

        /// <summary>
        /// �Ѷ��������ݷ����л��ɶ���
        /// </summary>
        /// <param name="type">Ҫת���ɵĶ������͡�</param>
        /// <param name="bytes">����������</param>
        /// <param name="encoding">���롣</param>
        /// <returns>����</returns>
        object FromBinary(Type type, byte[] bytes, Encoding encoding);

		/// <summary>
		/// �Ѷ��������ݷ����л��ɶ���
		/// </summary>
		/// <param name="type">Ҫת���ɵĶ������͡�</param>
		/// <param name="bytes">����������</param>
		/// <param name="encoding">���롣</param>
		/// <param name="extraTypes">Ҫ���л��������������͵� Type ���顣</param>
		/// <returns>����</returns>
		object FromBinary(Type type, byte[] bytes, Encoding encoding, Type[] extraTypes);

		#endregion
	}
}