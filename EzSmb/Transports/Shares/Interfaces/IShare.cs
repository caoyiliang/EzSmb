using EzSmb.Params;
using EzSmb.Paths;
using EzSmb.Shareds.Interfaces;
using System;
using System.IO;

namespace EzSmb.Transports.Shares.Interfaces
{
    internal interface IShare : IErrorManaged, IDisposable
    {
        bool IsConnected { get; }
        Node GetNode(PathSet pathSet, FixedParamSet paramSet);
        Node[] GetList(Node node);
        MemoryStream Read(Node node);
        bool Write(Node node, Stream stream);
        Node CreateFolder(Node node, string folderName);
        bool Delete(Node node);
        Node Move(Node node, string newPath);
    }
}