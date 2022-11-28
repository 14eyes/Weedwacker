// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetGachaInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetGachaInfoRsp.proto</summary>
  public static partial class GetGachaInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetGachaInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetGachaInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHZXRHYWNoYUluZm9Sc3AucHJvdG8aD0dhY2hhSW5mby5wcm90byK9AQoP",
            "R2V0R2FjaGFJbmZvUnNwEiEKGWlzX3VuZGVyX2dlbmVyYWxfcmVzdHJpY3QY",
            "BiABKAgSFAoMZ2FjaGFfcmFuZG9tGAkgASgNEg8KB3JldGNvZGUYCiABKAUS",
            "IAoYaXNfdW5kZXJfbWlub3JzX3Jlc3RyaWN0GAIgASgIEhkKEWRhaWx5X2dh",
            "Y2hhX3RpbWVzGAUgASgNEiMKD2dhY2hhX2luZm9fbGlzdBgNIAMoCzIKLkdh",
            "Y2hhSW5mb0IiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GachaInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetGachaInfoRsp), global::Weedwacker.Shared.Network.Proto.GetGachaInfoRsp.Parser, new[]{ "IsUnderGeneralRestrict", "GachaRandom", "Retcode", "IsUnderMinorsRestrict", "DailyGachaTimes", "GachaInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1598
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GetGachaInfoRsp : pb::IMessage<GetGachaInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetGachaInfoRsp> _parser = new pb::MessageParser<GetGachaInfoRsp>(() => new GetGachaInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetGachaInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetGachaInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGachaInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGachaInfoRsp(GetGachaInfoRsp other) : this() {
      isUnderGeneralRestrict_ = other.isUnderGeneralRestrict_;
      gachaRandom_ = other.gachaRandom_;
      retcode_ = other.retcode_;
      isUnderMinorsRestrict_ = other.isUnderMinorsRestrict_;
      dailyGachaTimes_ = other.dailyGachaTimes_;
      gachaInfoList_ = other.gachaInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGachaInfoRsp Clone() {
      return new GetGachaInfoRsp(this);
    }

    /// <summary>Field number for the "is_under_general_restrict" field.</summary>
    public const int IsUnderGeneralRestrictFieldNumber = 6;
    private bool isUnderGeneralRestrict_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnderGeneralRestrict {
      get { return isUnderGeneralRestrict_; }
      set {
        isUnderGeneralRestrict_ = value;
      }
    }

    /// <summary>Field number for the "gacha_random" field.</summary>
    public const int GachaRandomFieldNumber = 9;
    private uint gachaRandom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaRandom {
      get { return gachaRandom_; }
      set {
        gachaRandom_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "is_under_minors_restrict" field.</summary>
    public const int IsUnderMinorsRestrictFieldNumber = 2;
    private bool isUnderMinorsRestrict_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnderMinorsRestrict {
      get { return isUnderMinorsRestrict_; }
      set {
        isUnderMinorsRestrict_ = value;
      }
    }

    /// <summary>Field number for the "daily_gacha_times" field.</summary>
    public const int DailyGachaTimesFieldNumber = 5;
    private uint dailyGachaTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DailyGachaTimes {
      get { return dailyGachaTimes_; }
      set {
        dailyGachaTimes_ = value;
      }
    }

    /// <summary>Field number for the "gacha_info_list" field.</summary>
    public const int GachaInfoListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GachaInfo> _repeated_gachaInfoList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Shared.Network.Proto.GachaInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaInfo> gachaInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaInfo> GachaInfoList {
      get { return gachaInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetGachaInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetGachaInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsUnderGeneralRestrict != other.IsUnderGeneralRestrict) return false;
      if (GachaRandom != other.GachaRandom) return false;
      if (Retcode != other.Retcode) return false;
      if (IsUnderMinorsRestrict != other.IsUnderMinorsRestrict) return false;
      if (DailyGachaTimes != other.DailyGachaTimes) return false;
      if(!gachaInfoList_.Equals(other.gachaInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsUnderGeneralRestrict != false) hash ^= IsUnderGeneralRestrict.GetHashCode();
      if (GachaRandom != 0) hash ^= GachaRandom.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (IsUnderMinorsRestrict != false) hash ^= IsUnderMinorsRestrict.GetHashCode();
      if (DailyGachaTimes != 0) hash ^= DailyGachaTimes.GetHashCode();
      hash ^= gachaInfoList_.GetHashCode();
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
      if (IsUnderMinorsRestrict != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsUnderMinorsRestrict);
      }
      if (DailyGachaTimes != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DailyGachaTimes);
      }
      if (IsUnderGeneralRestrict != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsUnderGeneralRestrict);
      }
      if (GachaRandom != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GachaRandom);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      gachaInfoList_.WriteTo(output, _repeated_gachaInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsUnderMinorsRestrict != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsUnderMinorsRestrict);
      }
      if (DailyGachaTimes != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DailyGachaTimes);
      }
      if (IsUnderGeneralRestrict != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsUnderGeneralRestrict);
      }
      if (GachaRandom != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GachaRandom);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      gachaInfoList_.WriteTo(ref output, _repeated_gachaInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsUnderGeneralRestrict != false) {
        size += 1 + 1;
      }
      if (GachaRandom != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaRandom);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (IsUnderMinorsRestrict != false) {
        size += 1 + 1;
      }
      if (DailyGachaTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DailyGachaTimes);
      }
      size += gachaInfoList_.CalculateSize(_repeated_gachaInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetGachaInfoRsp other) {
      if (other == null) {
        return;
      }
      if (other.IsUnderGeneralRestrict != false) {
        IsUnderGeneralRestrict = other.IsUnderGeneralRestrict;
      }
      if (other.GachaRandom != 0) {
        GachaRandom = other.GachaRandom;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.IsUnderMinorsRestrict != false) {
        IsUnderMinorsRestrict = other.IsUnderMinorsRestrict;
      }
      if (other.DailyGachaTimes != 0) {
        DailyGachaTimes = other.DailyGachaTimes;
      }
      gachaInfoList_.Add(other.gachaInfoList_);
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
            IsUnderMinorsRestrict = input.ReadBool();
            break;
          }
          case 40: {
            DailyGachaTimes = input.ReadUInt32();
            break;
          }
          case 48: {
            IsUnderGeneralRestrict = input.ReadBool();
            break;
          }
          case 72: {
            GachaRandom = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 106: {
            gachaInfoList_.AddEntriesFrom(input, _repeated_gachaInfoList_codec);
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
            IsUnderMinorsRestrict = input.ReadBool();
            break;
          }
          case 40: {
            DailyGachaTimes = input.ReadUInt32();
            break;
          }
          case 48: {
            IsUnderGeneralRestrict = input.ReadBool();
            break;
          }
          case 72: {
            GachaRandom = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 106: {
            gachaInfoList_.AddEntriesFrom(ref input, _repeated_gachaInfoList_codec);
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
