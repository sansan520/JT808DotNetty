// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JT808AtomicCounterService.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace JT808.GrpcDashbord.AtomicCounterGrpcService {

  /// <summary>Holder for reflection information generated from JT808AtomicCounterService.proto</summary>
  public static partial class JT808AtomicCounterServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for JT808AtomicCounterService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JT808AtomicCounterServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9KVDgwOEF0b21pY0NvdW50ZXJTZXJ2aWNlLnByb3RvEitKVDgwOC5HcnBj",
            "RGFzaGJvcmQuQXRvbWljQ291bnRlckdycGNTZXJ2aWNlGhJFbXB0eVJlcXVl",
            "c3QucHJvdG8iQwoSQXRvbWljQ291bnRlclJlcGx5EhcKD01zZ1N1Y2Nlc3ND",
            "b3VudBgBIAEoBRIUCgxNc2dGYWlsQ291bnQYAiABKAUysAIKFEF0b21pY0Nv",
            "dW50ZXJTZXJ2aWNlEooBChNHZXRUY3BBdG9taWNDb3VudGVyEjAuSlQ4MDgu",
            "R3JwY0Rhc2hib3JkLlNlcnZpY2VHcnBjQmFzZS5FbXB0eVJlcXVlc3QaPy5K",
            "VDgwOC5HcnBjRGFzaGJvcmQuQXRvbWljQ291bnRlckdycGNTZXJ2aWNlLkF0",
            "b21pY0NvdW50ZXJSZXBseSIAEooBChNHZXRVZHBBdG9taWNDb3VudGVyEjAu",
            "SlQ4MDguR3JwY0Rhc2hib3JkLlNlcnZpY2VHcnBjQmFzZS5FbXB0eVJlcXVl",
            "c3QaPy5KVDgwOC5HcnBjRGFzaGJvcmQuQXRvbWljQ291bnRlckdycGNTZXJ2",
            "aWNlLkF0b21pY0NvdW50ZXJSZXBseSIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply), global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply.Parser, new[]{ "MsgSuccessCount", "MsgFailCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AtomicCounterReply : pb::IMessage<AtomicCounterReply> {
    private static readonly pb::MessageParser<AtomicCounterReply> _parser = new pb::MessageParser<AtomicCounterReply>(() => new AtomicCounterReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AtomicCounterReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::JT808.GrpcDashbord.AtomicCounterGrpcService.JT808AtomicCounterServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtomicCounterReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtomicCounterReply(AtomicCounterReply other) : this() {
      msgSuccessCount_ = other.msgSuccessCount_;
      msgFailCount_ = other.msgFailCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtomicCounterReply Clone() {
      return new AtomicCounterReply(this);
    }

    /// <summary>Field number for the "MsgSuccessCount" field.</summary>
    public const int MsgSuccessCountFieldNumber = 1;
    private int msgSuccessCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MsgSuccessCount {
      get { return msgSuccessCount_; }
      set {
        msgSuccessCount_ = value;
      }
    }

    /// <summary>Field number for the "MsgFailCount" field.</summary>
    public const int MsgFailCountFieldNumber = 2;
    private int msgFailCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MsgFailCount {
      get { return msgFailCount_; }
      set {
        msgFailCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AtomicCounterReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AtomicCounterReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MsgSuccessCount != other.MsgSuccessCount) return false;
      if (MsgFailCount != other.MsgFailCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MsgSuccessCount != 0) hash ^= MsgSuccessCount.GetHashCode();
      if (MsgFailCount != 0) hash ^= MsgFailCount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MsgSuccessCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MsgSuccessCount);
      }
      if (MsgFailCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MsgFailCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MsgSuccessCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MsgSuccessCount);
      }
      if (MsgFailCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MsgFailCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AtomicCounterReply other) {
      if (other == null) {
        return;
      }
      if (other.MsgSuccessCount != 0) {
        MsgSuccessCount = other.MsgSuccessCount;
      }
      if (other.MsgFailCount != 0) {
        MsgFailCount = other.MsgFailCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            MsgSuccessCount = input.ReadInt32();
            break;
          }
          case 16: {
            MsgFailCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code