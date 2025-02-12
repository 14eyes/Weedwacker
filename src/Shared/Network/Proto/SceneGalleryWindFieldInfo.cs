// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryWindFieldInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneGalleryWindFieldInfo.proto</summary>
  public static partial class SceneGalleryWindFieldInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryWindFieldInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryWindFieldInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TY2VuZUdhbGxlcnlXaW5kRmllbGRJbmZvLnByb3RvIvMBChlTY2VuZUdh",
            "bGxlcnlXaW5kRmllbGRJbmZvEhoKEmtpbGxlZF9tb25zdGVyX251bRgFIAEo",
            "DRIgChhjaGFsbGVuZ2VfYmFsbF9tYXhfY291bnQYDCABKA0SDwoHc2hvd19p",
            "ZBgPIAEoDRIcChRjaGFsbGVuZ2VfdG90YWxfdGltZRgEIAEoDRIgChhjaGFs",
            "bGVuZ2VfYmFsbF9jdXJfY291bnQYCSABKA0SEAoIY29pbl9udW0YASABKA0S",
            "GwoTY2hhbGxlbmdlX3RpbWVzdGFtcBgNIAEoDRIYChBlbGVtZW50X2JhbGxf",
            "bnVtGAogASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneGalleryWindFieldInfo), global::Weedwacker.Shared.Network.Proto.SceneGalleryWindFieldInfo.Parser, new[]{ "KilledMonsterNum", "ChallengeBallMaxCount", "ShowId", "ChallengeTotalTime", "ChallengeBallCurCount", "CoinNum", "ChallengeTimestamp", "ElementBallNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryWindFieldInfo : pb::IMessage<SceneGalleryWindFieldInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryWindFieldInfo> _parser = new pb::MessageParser<SceneGalleryWindFieldInfo>(() => new SceneGalleryWindFieldInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryWindFieldInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneGalleryWindFieldInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryWindFieldInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryWindFieldInfo(SceneGalleryWindFieldInfo other) : this() {
      killedMonsterNum_ = other.killedMonsterNum_;
      challengeBallMaxCount_ = other.challengeBallMaxCount_;
      showId_ = other.showId_;
      challengeTotalTime_ = other.challengeTotalTime_;
      challengeBallCurCount_ = other.challengeBallCurCount_;
      coinNum_ = other.coinNum_;
      challengeTimestamp_ = other.challengeTimestamp_;
      elementBallNum_ = other.elementBallNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryWindFieldInfo Clone() {
      return new SceneGalleryWindFieldInfo(this);
    }

    /// <summary>Field number for the "killed_monster_num" field.</summary>
    public const int KilledMonsterNumFieldNumber = 5;
    private uint killedMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KilledMonsterNum {
      get { return killedMonsterNum_; }
      set {
        killedMonsterNum_ = value;
      }
    }

    /// <summary>Field number for the "challenge_ball_max_count" field.</summary>
    public const int ChallengeBallMaxCountFieldNumber = 12;
    private uint challengeBallMaxCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeBallMaxCount {
      get { return challengeBallMaxCount_; }
      set {
        challengeBallMaxCount_ = value;
      }
    }

    /// <summary>Field number for the "show_id" field.</summary>
    public const int ShowIdFieldNumber = 15;
    private uint showId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShowId {
      get { return showId_; }
      set {
        showId_ = value;
      }
    }

    /// <summary>Field number for the "challenge_total_time" field.</summary>
    public const int ChallengeTotalTimeFieldNumber = 4;
    private uint challengeTotalTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeTotalTime {
      get { return challengeTotalTime_; }
      set {
        challengeTotalTime_ = value;
      }
    }

    /// <summary>Field number for the "challenge_ball_cur_count" field.</summary>
    public const int ChallengeBallCurCountFieldNumber = 9;
    private uint challengeBallCurCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeBallCurCount {
      get { return challengeBallCurCount_; }
      set {
        challengeBallCurCount_ = value;
      }
    }

    /// <summary>Field number for the "coin_num" field.</summary>
    public const int CoinNumFieldNumber = 1;
    private uint coinNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinNum {
      get { return coinNum_; }
      set {
        coinNum_ = value;
      }
    }

    /// <summary>Field number for the "challenge_timestamp" field.</summary>
    public const int ChallengeTimestampFieldNumber = 13;
    private uint challengeTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeTimestamp {
      get { return challengeTimestamp_; }
      set {
        challengeTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "element_ball_num" field.</summary>
    public const int ElementBallNumFieldNumber = 10;
    private uint elementBallNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ElementBallNum {
      get { return elementBallNum_; }
      set {
        elementBallNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryWindFieldInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryWindFieldInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KilledMonsterNum != other.KilledMonsterNum) return false;
      if (ChallengeBallMaxCount != other.ChallengeBallMaxCount) return false;
      if (ShowId != other.ShowId) return false;
      if (ChallengeTotalTime != other.ChallengeTotalTime) return false;
      if (ChallengeBallCurCount != other.ChallengeBallCurCount) return false;
      if (CoinNum != other.CoinNum) return false;
      if (ChallengeTimestamp != other.ChallengeTimestamp) return false;
      if (ElementBallNum != other.ElementBallNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KilledMonsterNum != 0) hash ^= KilledMonsterNum.GetHashCode();
      if (ChallengeBallMaxCount != 0) hash ^= ChallengeBallMaxCount.GetHashCode();
      if (ShowId != 0) hash ^= ShowId.GetHashCode();
      if (ChallengeTotalTime != 0) hash ^= ChallengeTotalTime.GetHashCode();
      if (ChallengeBallCurCount != 0) hash ^= ChallengeBallCurCount.GetHashCode();
      if (CoinNum != 0) hash ^= CoinNum.GetHashCode();
      if (ChallengeTimestamp != 0) hash ^= ChallengeTimestamp.GetHashCode();
      if (ElementBallNum != 0) hash ^= ElementBallNum.GetHashCode();
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
      if (CoinNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CoinNum);
      }
      if (ChallengeTotalTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ChallengeTotalTime);
      }
      if (KilledMonsterNum != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(KilledMonsterNum);
      }
      if (ChallengeBallCurCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeBallCurCount);
      }
      if (ElementBallNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ElementBallNum);
      }
      if (ChallengeBallMaxCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeBallMaxCount);
      }
      if (ChallengeTimestamp != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeTimestamp);
      }
      if (ShowId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ShowId);
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
      if (CoinNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CoinNum);
      }
      if (ChallengeTotalTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ChallengeTotalTime);
      }
      if (KilledMonsterNum != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(KilledMonsterNum);
      }
      if (ChallengeBallCurCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeBallCurCount);
      }
      if (ElementBallNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ElementBallNum);
      }
      if (ChallengeBallMaxCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeBallMaxCount);
      }
      if (ChallengeTimestamp != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeTimestamp);
      }
      if (ShowId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ShowId);
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
      if (KilledMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KilledMonsterNum);
      }
      if (ChallengeBallMaxCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeBallMaxCount);
      }
      if (ShowId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShowId);
      }
      if (ChallengeTotalTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeTotalTime);
      }
      if (ChallengeBallCurCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeBallCurCount);
      }
      if (CoinNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinNum);
      }
      if (ChallengeTimestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeTimestamp);
      }
      if (ElementBallNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementBallNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryWindFieldInfo other) {
      if (other == null) {
        return;
      }
      if (other.KilledMonsterNum != 0) {
        KilledMonsterNum = other.KilledMonsterNum;
      }
      if (other.ChallengeBallMaxCount != 0) {
        ChallengeBallMaxCount = other.ChallengeBallMaxCount;
      }
      if (other.ShowId != 0) {
        ShowId = other.ShowId;
      }
      if (other.ChallengeTotalTime != 0) {
        ChallengeTotalTime = other.ChallengeTotalTime;
      }
      if (other.ChallengeBallCurCount != 0) {
        ChallengeBallCurCount = other.ChallengeBallCurCount;
      }
      if (other.CoinNum != 0) {
        CoinNum = other.CoinNum;
      }
      if (other.ChallengeTimestamp != 0) {
        ChallengeTimestamp = other.ChallengeTimestamp;
      }
      if (other.ElementBallNum != 0) {
        ElementBallNum = other.ElementBallNum;
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
          case 8: {
            CoinNum = input.ReadUInt32();
            break;
          }
          case 32: {
            ChallengeTotalTime = input.ReadUInt32();
            break;
          }
          case 40: {
            KilledMonsterNum = input.ReadUInt32();
            break;
          }
          case 72: {
            ChallengeBallCurCount = input.ReadUInt32();
            break;
          }
          case 80: {
            ElementBallNum = input.ReadUInt32();
            break;
          }
          case 96: {
            ChallengeBallMaxCount = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeTimestamp = input.ReadUInt32();
            break;
          }
          case 120: {
            ShowId = input.ReadUInt32();
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
          case 8: {
            CoinNum = input.ReadUInt32();
            break;
          }
          case 32: {
            ChallengeTotalTime = input.ReadUInt32();
            break;
          }
          case 40: {
            KilledMonsterNum = input.ReadUInt32();
            break;
          }
          case 72: {
            ChallengeBallCurCount = input.ReadUInt32();
            break;
          }
          case 80: {
            ElementBallNum = input.ReadUInt32();
            break;
          }
          case 96: {
            ChallengeBallMaxCount = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeTimestamp = input.ReadUInt32();
            break;
          }
          case 120: {
            ShowId = input.ReadUInt32();
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
