// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityAcceptGiftResultInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ActivityAcceptGiftResultInfo.proto</summary>
  public static partial class ActivityAcceptGiftResultInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ActivityAcceptGiftResultInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityAcceptGiftResultInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBY3Rpdml0eUFjY2VwdEdpZnRSZXN1bHRJbmZvLnByb3RvIscCChxBY3Rp",
            "dml0eUFjY2VwdEdpZnRSZXN1bHRJbmZvElQKFXVuYWNjZXB0X2dpZnRfbnVt",
            "X21hcBgDIAMoCzI1LkFjdGl2aXR5QWNjZXB0R2lmdFJlc3VsdEluZm8uVW5h",
            "Y2NlcHRHaWZ0TnVtTWFwRW50cnkSCwoDdWlkGAYgASgNElAKE2FjY2VwdF9n",
            "aWZ0X251bV9tYXAYDSADKAsyMy5BY3Rpdml0eUFjY2VwdEdpZnRSZXN1bHRJ",
            "bmZvLkFjY2VwdEdpZnROdW1NYXBFbnRyeRo5ChdVbmFjY2VwdEdpZnROdW1N",
            "YXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBGjcKFUFj",
            "Y2VwdEdpZnROdW1NYXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiAB",
            "KA06AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ActivityAcceptGiftResultInfo), global::Weedwacker.Shared.Network.Proto.ActivityAcceptGiftResultInfo.Parser, new[]{ "UnacceptGiftNumMap", "Uid", "AcceptGiftNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ActivityAcceptGiftResultInfo : pb::IMessage<ActivityAcceptGiftResultInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityAcceptGiftResultInfo> _parser = new pb::MessageParser<ActivityAcceptGiftResultInfo>(() => new ActivityAcceptGiftResultInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityAcceptGiftResultInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ActivityAcceptGiftResultInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityAcceptGiftResultInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityAcceptGiftResultInfo(ActivityAcceptGiftResultInfo other) : this() {
      unacceptGiftNumMap_ = other.unacceptGiftNumMap_.Clone();
      uid_ = other.uid_;
      acceptGiftNumMap_ = other.acceptGiftNumMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityAcceptGiftResultInfo Clone() {
      return new ActivityAcceptGiftResultInfo(this);
    }

    /// <summary>Field number for the "unaccept_gift_num_map" field.</summary>
    public const int UnacceptGiftNumMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unacceptGiftNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> unacceptGiftNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> UnacceptGiftNumMap {
      get { return unacceptGiftNumMap_; }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 6;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "accept_gift_num_map" field.</summary>
    public const int AcceptGiftNumMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_acceptGiftNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> acceptGiftNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> AcceptGiftNumMap {
      get { return acceptGiftNumMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityAcceptGiftResultInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityAcceptGiftResultInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!UnacceptGiftNumMap.Equals(other.UnacceptGiftNumMap)) return false;
      if (Uid != other.Uid) return false;
      if (!AcceptGiftNumMap.Equals(other.AcceptGiftNumMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= UnacceptGiftNumMap.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= AcceptGiftNumMap.GetHashCode();
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
      unacceptGiftNumMap_.WriteTo(output, _map_unacceptGiftNumMap_codec);
      if (Uid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Uid);
      }
      acceptGiftNumMap_.WriteTo(output, _map_acceptGiftNumMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unacceptGiftNumMap_.WriteTo(ref output, _map_unacceptGiftNumMap_codec);
      if (Uid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Uid);
      }
      acceptGiftNumMap_.WriteTo(ref output, _map_acceptGiftNumMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unacceptGiftNumMap_.CalculateSize(_map_unacceptGiftNumMap_codec);
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += acceptGiftNumMap_.CalculateSize(_map_acceptGiftNumMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityAcceptGiftResultInfo other) {
      if (other == null) {
        return;
      }
      unacceptGiftNumMap_.Add(other.unacceptGiftNumMap_);
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      acceptGiftNumMap_.Add(other.acceptGiftNumMap_);
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
          case 26: {
            unacceptGiftNumMap_.AddEntriesFrom(input, _map_unacceptGiftNumMap_codec);
            break;
          }
          case 48: {
            Uid = input.ReadUInt32();
            break;
          }
          case 106: {
            acceptGiftNumMap_.AddEntriesFrom(input, _map_acceptGiftNumMap_codec);
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
          case 26: {
            unacceptGiftNumMap_.AddEntriesFrom(ref input, _map_unacceptGiftNumMap_codec);
            break;
          }
          case 48: {
            Uid = input.ReadUInt32();
            break;
          }
          case 106: {
            acceptGiftNumMap_.AddEntriesFrom(ref input, _map_acceptGiftNumMap_codec);
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
