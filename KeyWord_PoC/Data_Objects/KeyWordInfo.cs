using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace KeyWord_PoC
{
	public class KeyWordInfo
	{
		public MemberInfo Method;
		public Type ParentClass;

		public KeyWordInfo(MemberInfo method, Type parentClass)
		{
			this.Method = method;
			this.ParentClass = parentClass;
		}
	}
}
