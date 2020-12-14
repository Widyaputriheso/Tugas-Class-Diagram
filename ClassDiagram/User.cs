using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
	public class User : Buku
	{

		public int Password
		{
			get => default;
			set
			{
			}
		}

		public int UserName
		{
			get => default;
			set
			{
			}
		}

		public void Get_AcountAdmin()
		{
			throw new System.NotImplementedException();
		}

		public void Set_AcountAdmin()
		{
			throw new System.NotImplementedException();
		}
	}
}