﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Server.Algorithm
{
	// Token: 0x02000068 RID: 104
	public static class Sha256
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x0002C0FC File Offset: 0x0002C0FC
		public static string ComputeHash(string input)
		{
			byte[] array = Encoding.UTF8.GetBytes(input);
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				array = sha256Managed.ComputeHash(array);
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString().ToUpper();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0002C188 File Offset: 0x0002C188
		public static byte[] ComputeHash(byte[] input)
		{
			byte[] result;
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				result = sha256Managed.ComputeHash(input);
			}
			return result;
		}
	}
}
