// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryInstableSprayBuffInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneGalleryInstableSprayBuffInfo.proto</summary>
  public static partial class SceneGalleryInstableSprayBuffInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryInstableSprayBuffInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryInstableSprayBuffInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTY2VuZUdhbGxlcnlJbnN0YWJsZVNwcmF5QnVmZkluZm8ucHJvdG8iYgoh",
            "U2NlbmVHYWxsZXJ5SW5zdGFibGVTcHJheUJ1ZmZJbmZvEg8KB2J1ZmZfaWQY",
            "BiABKA0SFQoNYnVmZl9lbmRfdGltZRgJIAEoBBIVCg1idWZmX21heF90aW1l",
            "GAQgASgEQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneGalleryInstableSprayBuffInfo), global::Weedwacker.Shared.Network.Proto.SceneGalleryInstableSprayBuffInfo.Parser, new[]{ "BuffId", "BuffEndTime", "BuffMaxTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryInstableSprayBuffInfo : pb::IMessage<SceneGalleryInstableSprayBuffInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryInstableSprayBuffInfo> _parser = new pb::MessageParser<SceneGalleryInstableSprayBuffInfo>(() => new SceneGalleryInstableSprayBuffInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryInstableSprayBuffInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneGalleryInstableSprayBuffInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryInstableSprayBuffInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryInstableSprayBuffInfo(SceneGalleryInstableSprayBuffInfo other) : this() {
      buffId_ = other.buffId_;
      buffEndTime_ = other.buffEndTime_;
      buffMaxTime_ = other.buffMaxTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryInstableSprayBuffInfo Clone() {
      return new SceneGalleryInstableSprayBuffInfo(this);
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 6;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "buff_end_time" field.</summary>
    public const int BuffEndTimeFieldNumber = 9;
    private ulong buffEndTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BuffEndTime {
      get { return buffEndTime_; }
      set {
        buffEndTime_ = value;
      }
    }

    /// <summary>Field number for the "buff_max_time" field.</summary>
    public const int BuffMaxTimeFieldNumber = 4;
    private ulong buffMaxTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BuffMaxTime {
      get { return buffMaxTime_; }
      set {
        buffMaxTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryInstableSprayBuffInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryInstableSprayBuffInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuffId != other.BuffId) return false;
      if (BuffEndTime != other.BuffEndTime) return false;
      if (BuffMaxTime != other.BuffMaxTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (BuffEndTime != 0UL) hash ^= BuffEndTime.GetHashCode();
      if (BuffMaxTime != 0UL) hash ^= BuffMaxTime.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (BuffMaxTime != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(BuffMaxTime);
      }
      if (BuffId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BuffId);
      }
      if (BuffEndTime != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(BuffEndTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BuffMaxTime != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(BuffMaxTime);
      }
      if (BuffId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BuffId);
      }
      if (BuffEndTime != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(BuffEndTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (BuffEndTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BuffEndTime);
      }
      if (BuffMaxTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BuffMaxTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryInstableSprayBuffInfo other) {
      if (other == null) {
        return;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.BuffEndTime != 0UL) {
        BuffEndTime = other.BuffEndTime;
      }
      if (other.BuffMaxTime != 0UL) {
        BuffMaxTime = other.BuffMaxTime;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 32: {
            BuffMaxTime = input.ReadUInt64();
            break;
          }
          case 48: {
            BuffId = input.ReadUInt32();
            break;
          }
          case 72: {
            BuffEndTime = input.ReadUInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 32: {
            BuffMaxTime = input.ReadUInt64();
            break;
          }
          case 48: {
            BuffId = input.ReadUInt32();
            break;
          }
          case 72: {
            BuffEndTime = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
