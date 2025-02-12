// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarTeamAllDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AvatarTeamAllDataNotify.proto</summary>
  public static partial class AvatarTeamAllDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarTeamAllDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarTeamAllDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1BdmF0YXJUZWFtQWxsRGF0YU5vdGlmeS5wcm90bxoQQXZhdGFyVGVhbS5w",
            "cm90byLoAQoXQXZhdGFyVGVhbUFsbERhdGFOb3RpZnkSHQoVdGVtcF9hdmF0",
            "YXJfZ3VpZF9saXN0GAYgAygEEkQKD2F2YXRhcl90ZWFtX21hcBgDIAMoCzIr",
            "LkF2YXRhclRlYW1BbGxEYXRhTm90aWZ5LkF2YXRhclRlYW1NYXBFbnRyeRIl",
            "Ch1iYWNrdXBfYXZhdGFyX3RlYW1fb3JkZXJfbGlzdBgBIAMoDRpBChJBdmF0",
            "YXJUZWFtTWFwRW50cnkSCwoDa2V5GAEgASgNEhoKBXZhbHVlGAIgASgLMgsu",
            "QXZhdGFyVGVhbToCOAFCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AvatarTeamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AvatarTeamAllDataNotify), global::Weedwacker.Shared.Network.Proto.AvatarTeamAllDataNotify.Parser, new[]{ "TempAvatarGuidList", "AvatarTeamMap", "BackupAvatarTeamOrderList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1749
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class AvatarTeamAllDataNotify : pb::IMessage<AvatarTeamAllDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarTeamAllDataNotify> _parser = new pb::MessageParser<AvatarTeamAllDataNotify>(() => new AvatarTeamAllDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarTeamAllDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AvatarTeamAllDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarTeamAllDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarTeamAllDataNotify(AvatarTeamAllDataNotify other) : this() {
      tempAvatarGuidList_ = other.tempAvatarGuidList_.Clone();
      avatarTeamMap_ = other.avatarTeamMap_.Clone();
      backupAvatarTeamOrderList_ = other.backupAvatarTeamOrderList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarTeamAllDataNotify Clone() {
      return new AvatarTeamAllDataNotify(this);
    }

    /// <summary>Field number for the "temp_avatar_guid_list" field.</summary>
    public const int TempAvatarGuidListFieldNumber = 6;
    private static readonly pb::FieldCodec<ulong> _repeated_tempAvatarGuidList_codec
        = pb::FieldCodec.ForUInt64(50);
    private readonly pbc::RepeatedField<ulong> tempAvatarGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> TempAvatarGuidList {
      get { return tempAvatarGuidList_; }
    }

    /// <summary>Field number for the "avatar_team_map" field.</summary>
    public const int AvatarTeamMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AvatarTeam>.Codec _map_avatarTeamMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AvatarTeam>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.AvatarTeam.Parser), 26);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AvatarTeam> avatarTeamMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AvatarTeam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AvatarTeam> AvatarTeamMap {
      get { return avatarTeamMap_; }
    }

    /// <summary>Field number for the "backup_avatar_team_order_list" field.</summary>
    public const int BackupAvatarTeamOrderListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_backupAvatarTeamOrderList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> backupAvatarTeamOrderList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BackupAvatarTeamOrderList {
      get { return backupAvatarTeamOrderList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarTeamAllDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarTeamAllDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!tempAvatarGuidList_.Equals(other.tempAvatarGuidList_)) return false;
      if (!AvatarTeamMap.Equals(other.AvatarTeamMap)) return false;
      if(!backupAvatarTeamOrderList_.Equals(other.backupAvatarTeamOrderList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= tempAvatarGuidList_.GetHashCode();
      hash ^= AvatarTeamMap.GetHashCode();
      hash ^= backupAvatarTeamOrderList_.GetHashCode();
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
      backupAvatarTeamOrderList_.WriteTo(output, _repeated_backupAvatarTeamOrderList_codec);
      avatarTeamMap_.WriteTo(output, _map_avatarTeamMap_codec);
      tempAvatarGuidList_.WriteTo(output, _repeated_tempAvatarGuidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      backupAvatarTeamOrderList_.WriteTo(ref output, _repeated_backupAvatarTeamOrderList_codec);
      avatarTeamMap_.WriteTo(ref output, _map_avatarTeamMap_codec);
      tempAvatarGuidList_.WriteTo(ref output, _repeated_tempAvatarGuidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += tempAvatarGuidList_.CalculateSize(_repeated_tempAvatarGuidList_codec);
      size += avatarTeamMap_.CalculateSize(_map_avatarTeamMap_codec);
      size += backupAvatarTeamOrderList_.CalculateSize(_repeated_backupAvatarTeamOrderList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarTeamAllDataNotify other) {
      if (other == null) {
        return;
      }
      tempAvatarGuidList_.Add(other.tempAvatarGuidList_);
      avatarTeamMap_.Add(other.avatarTeamMap_);
      backupAvatarTeamOrderList_.Add(other.backupAvatarTeamOrderList_);
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
          case 10:
          case 8: {
            backupAvatarTeamOrderList_.AddEntriesFrom(input, _repeated_backupAvatarTeamOrderList_codec);
            break;
          }
          case 26: {
            avatarTeamMap_.AddEntriesFrom(input, _map_avatarTeamMap_codec);
            break;
          }
          case 50:
          case 48: {
            tempAvatarGuidList_.AddEntriesFrom(input, _repeated_tempAvatarGuidList_codec);
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
          case 10:
          case 8: {
            backupAvatarTeamOrderList_.AddEntriesFrom(ref input, _repeated_backupAvatarTeamOrderList_codec);
            break;
          }
          case 26: {
            avatarTeamMap_.AddEntriesFrom(ref input, _map_avatarTeamMap_codec);
            break;
          }
          case 50:
          case 48: {
            tempAvatarGuidList_.AddEntriesFrom(ref input, _repeated_tempAvatarGuidList_codec);
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
