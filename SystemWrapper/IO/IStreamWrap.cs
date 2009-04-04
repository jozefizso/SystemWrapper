/*
 * Copyright Iain Sproat, 2009
 * 
 *
 */
using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of IStreamWrap.
	/// </summary>
	public interface IStreamWrap
	{
		Stream StreamInstance{ get; }
	}
}
