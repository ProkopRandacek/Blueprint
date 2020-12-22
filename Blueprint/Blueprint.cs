using System;
using System.IO;
using Newtonsoft.Json;
using zlib;

// ReSharper disable MemberCanBePrivate.Global

namespace Blueprint
{
	//https://wiki.factorio.com/index.php?title=Blueprint_string_format&oldid=182439
    public class Blueprint
    {
	    /// <summary>
	    /// The name of the item that was saved ("blueprint" in vanilla).
	    /// </summary>
	    public string Item;

	    /// <summary>
	    /// The name of the blueprint set by the user.
	    /// </summary>
	    public string Label;

	    /// <summary>
	    /// The color of the label of this blueprint. Optional.
	    /// </summary>
	    public Color LabelColor;

	    /// <summary>
	    /// The actual content of the blueprint
	    /// </summary>
	    public Entity[] Entities;

	    /// <summary>
	    /// The tiles included in the blueprint
	    /// </summary>
	    public Tile[] Tiles;

	    /// <summary>
	    /// The icons of the blueprint set by the user
	    /// </summary>
	    public Icon[] Icons;

	    /// <summary>
	    /// The schedules for trains in this blueprint
	    /// </summary>
	    public Schedule[] Schedules;

	    /// <summary>
	    /// The map version of the map the blueprint was created in.
	    /// </summary>
	    public int Version;

	    public Blueprint(string item, string label, Entity[] entities, Tile[] tiles, Icon[] icons, Schedule[] schedules)
	    {
		    Item      = item;
		    Label     = label;
		    Entities  = entities;
		    Tiles     = tiles;
		    Icons     = icons;
		    Schedules = schedules;
	    }

	    public static Blueprint BlueprintFromString(string bps)
	    {
		    throw new NotImplementedException();
	    }

	    #region private static
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
	    #endregion
    }
}
