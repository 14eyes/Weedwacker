// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonSocial.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CustomDungeonSocial.proto</summary>
  public static partial class CustomDungeonSocialReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonSocial.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonSocialReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDdXN0b21EdW5nZW9uU29jaWFsLnByb3RvIl0KE0N1c3RvbUR1bmdlb25T",
            "b2NpYWwSDwoHd2luX251bRgEIAEoDRIQCghsaWtlX251bRgMIAEoDRIQCghw",
            "bGF5X251bRgHIAEoDRIRCglzdG9yZV9udW0YAiABKA1CIqoCH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CustomDungeonSocial), global::Weedwacker.Shared.Network.Proto.CustomDungeonSocial.Parser, new[]{ "WinNum", "LikeNum", "PlayNum", "StoreNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonSocial : pb::IMessage<CustomDungeonSocial>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonSocial> _parser = new pb::MessageParser<CustomDungeonSocial>(() => new CustomDungeonSocial());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonSocial> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CustomDungeonSocialReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSocial() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSocial(CustomDungeonSocial other) : this() {
      winNum_ = other.winNum_;
      likeNum_ = other.likeNum_;
      playNum_ = other.playNum_;
      storeNum_ = other.storeNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSocial Clone() {
      return new CustomDungeonSocial(this);
    }

    /// <summary>Field number for the "win_num" field.</summary>
    public const int WinNumFieldNumber = 4;
    private uint winNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WinNum {
      get { return winNum_; }
      set {
        winNum_ = value;
      }
    }

    /// <summary>Field number for the "like_num" field.</summary>
    public const int LikeNumFieldNumber = 12;
    private uint likeNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LikeNum {
      get { return likeNum_; }
      set {
        likeNum_ = value;
      }
    }

    /// <summary>Field number for the "play_num" field.</summary>
    public const int PlayNumFieldNumber = 7;
    private uint playNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayNum {
      get { return playNum_; }
      set {
        playNum_ = value;
      }
    }

    /// <summary>Field number for the "store_num" field.</summary>
    public const int StoreNumFieldNumber = 2;
    private uint storeNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StoreNum {
      get { return storeNum_; }
      set {
        storeNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonSocial);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonSocial other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WinNum != other.WinNum) return false;
      if (LikeNum != other.LikeNum) return false;
      if (PlayNum != other.PlayNum) return false;
      if (StoreNum != other.StoreNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WinNum != 0) hash ^= WinNum.GetHashCode();
      if (LikeNum != 0) hash ^= LikeNum.GetHashCode();
      if (PlayNum != 0) hash ^= PlayNum.GetHashCode();
      if (StoreNum != 0) hash ^= StoreNum.GetHashCode();
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
      if (StoreNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(StoreNum);
      }
      if (WinNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WinNum);
      }
      if (PlayNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PlayNum);
      }
      if (LikeNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LikeNum);
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
      if (StoreNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(StoreNum);
      }
      if (WinNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WinNum);
      }
      if (PlayNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PlayNum);
      }
      if (LikeNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LikeNum);
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
      if (WinNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WinNum);
      }
      if (LikeNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LikeNum);
      }
      if (PlayNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayNum);
      }
      if (StoreNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonSocial other) {
      if (other == null) {
        return;
      }
      if (other.WinNum != 0) {
        WinNum = other.WinNum;
      }
      if (other.LikeNum != 0) {
        LikeNum = other.LikeNum;
      }
      if (other.PlayNum != 0) {
        PlayNum = other.PlayNum;
      }
      if (other.StoreNum != 0) {
        StoreNum = other.StoreNum;
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
          case 16: {
            StoreNum = input.ReadUInt32();
            break;
          }
          case 32: {
            WinNum = input.ReadUInt32();
            break;
          }
          case 56: {
            PlayNum = input.ReadUInt32();
            break;
          }
          case 96: {
            LikeNum = input.ReadUInt32();
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
          case 16: {
            StoreNum = input.ReadUInt32();
            break;
          }
          case 32: {
            WinNum = input.ReadUInt32();
            break;
          }
          case 56: {
            PlayNum = input.ReadUInt32();
            break;
          }
          case 96: {
            LikeNum = input.ReadUInt32();
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
