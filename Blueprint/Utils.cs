using System;
using System.IO;
using Newtonsoft.Json;
using zlib;

namespace Blueprint
{
    public static class Utils
    {
	    private static object BpString2Obj(string bps)
	    {
		    byte[] decoded = Convert.FromBase64String(bps);
		    DecompressData(decoded, out byte[] decompressed);
		    string json = System.Text.Encoding.Default.GetString(decompressed);
		    return JsonConvert.DeserializeObject(json) ?? throw new Exception(); // TODO intelligent exception maybe
	    }

	    private static void DecompressData(byte[] inData, out byte[] outData)
	    {
		    using MemoryStream  outMemoryStream = new MemoryStream();
		    using ZOutputStream outZStream      = new ZOutputStream(outMemoryStream);
		    using Stream        inMemoryStream  = new MemoryStream(inData);
		    CopyStream(inMemoryStream, outZStream);
		    outZStream.finish();
		    outData = outMemoryStream.ToArray();
	    }

	    private static void CopyStream(Stream input, Stream output)
	    {
		    byte[] buffer = new byte[2000];
		    int    len;
		    while ((len = input.Read(buffer, 0, 2000)) > 0)
			    output.Write(buffer, 0, len);
		    output.Flush();
	    }
    }
}