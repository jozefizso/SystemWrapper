using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInterface {
	public interface IWrapper<T> {
		T Instance { get; }
	}
}
