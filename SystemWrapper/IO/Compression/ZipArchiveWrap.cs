using System.Collections.ObjectModel;
using System.Linq;
using SystemInterface.IO.Compression;
using MicrosoftImpl = System.IO.Compression;

namespace SystemWrapper.IO.Compression {
	public class ZipArchiveWrap : IZipArchive {

		public MicrosoftImpl.ZipArchive Instance { get; private set; }

		public ZipArchiveWrap(MicrosoftImpl.ZipArchive Instance) {
			this.Instance = Instance;
		}

		public ReadOnlyCollection<IZipArchiveEntry> Entries {
			get {
				return new ReadOnlyCollection<IZipArchiveEntry>(Instance.Entries.Select(s => new ZipArchiveEntryWrap(s)).Cast<IZipArchiveEntry>().ToList());
			}
		}

		public MicrosoftImpl.ZipArchiveMode Mode {
			get {
				return Instance.Mode;
			}
		}

		public IZipArchiveEntry CreateEntry(string entryName) {
			return new ZipArchiveEntryWrap(Instance.CreateEntry(entryName));
		}

		public IZipArchiveEntry CreateEntry(string entryName, MicrosoftImpl.CompressionLevel compressionLevel) {
			return new ZipArchiveEntryWrap(Instance.CreateEntry(entryName, compressionLevel));
		}

		public IZipArchiveEntry GetEntry(string entryName) {
			return new ZipArchiveEntryWrap(Instance.GetEntry(entryName));
		}

		#region IDisposable Support
		private bool disposedValue = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing) {
			if (!disposedValue) {
				if (disposing) {
					Instance.Dispose();
				}
				disposedValue = true;
			}
		}
		
		public void Dispose() {
			Dispose(true);
		}
		#endregion
	}
}
