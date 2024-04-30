// See https://aka.ms/new-console-template for more information
using System.Net;
using YTSubConverter.Shared.Formats;


if (args.Length > 0)
{
    Stream stdout = Console.OpenStandardOutput();
    WebClient client = new WebClient();
    MemoryStream hey = new MemoryStream(client.DownloadData(args[0]));
    SubtitleDocument sourceDoc = SubtitleDocument.Load(hey, "srv3");
    SubtitleDocument destinationDoc = SubtitleDocument.Convert(sourceDoc, ".ass", true);
    destinationDoc.Save(stdout);
}
