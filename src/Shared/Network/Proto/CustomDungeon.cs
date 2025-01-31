// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeon.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CustomDungeon.proto</summary>
  public static partial class CustomDungeonReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNDdXN0b21EdW5nZW9uLnByb3RvGhdDdXN0b21EdW5nZW9uUm9vbS5wcm90",
            "bxoaQ3VzdG9tRHVuZ2VvblNldHRpbmcucHJvdG8iiAEKDUN1c3RvbUR1bmdl",
            "b24SJgoHc2V0dGluZxgBIAEoCzIVLkN1c3RvbUR1bmdlb25TZXR0aW5nEiUK",
            "CXJvb21fbGlzdBgPIAMoCzISLkN1c3RvbUR1bmdlb25Sb29tEhIKCmR1bmdl",
            "b25faWQYAyABKA0SFAoMZHVuZ2Vvbl9ndWlkGAogASgEQiKqAh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CustomDungeonRoomReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CustomDungeon), global::Weedwacker.Shared.Network.Proto.CustomDungeon.Parser, new[]{ "Setting", "RoomList", "DungeonId", "DungeonGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeon : pb::IMessage<CustomDungeon>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeon> _parser = new pb::MessageParser<CustomDungeon>(() => new CustomDungeon());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CustomDungeonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeon(CustomDungeon other) : this() {
      setting_ = other.setting_ != null ? other.setting_.Clone() : null;
      roomList_ = other.roomList_.Clone();
      dungeonId_ = other.dungeonId_;
      dungeonGuid_ = other.dungeonGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeon Clone() {
      return new CustomDungeon(this);
    }

    /// <summary>Field number for the "setting" field.</summary>
    public const int SettingFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting setting_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting Setting {
      get { return setting_; }
      set {
        setting_ = value;
      }
    }

    /// <summary>Field number for the "room_list" field.</summary>
    public const int RoomListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CustomDungeonRoom> _repeated_roomList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.CustomDungeonRoom.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CustomDungeonRoom> roomList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CustomDungeonRoom>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CustomDungeonRoom> RoomList {
      get { return roomList_; }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 3;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_guid" field.</summary>
    public const int DungeonGuidFieldNumber = 10;
    private ulong dungeonGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DungeonGuid {
      get { return dungeonGuid_; }
      set {
        dungeonGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Setting, other.Setting)) return false;
      if(!roomList_.Equals(other.roomList_)) return false;
      if (DungeonId != other.DungeonId) return false;
      if (DungeonGuid != other.DungeonGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (setting_ != null) hash ^= Setting.GetHashCode();
      hash ^= roomList_.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
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
      if (setting_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Setting);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonId);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(DungeonGuid);
      }
      roomList_.WriteTo(output, _repeated_roomList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (setting_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Setting);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonId);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(DungeonGuid);
      }
      roomList_.WriteTo(ref output, _repeated_roomList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (setting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Setting);
      }
      size += roomList_.CalculateSize(_repeated_roomList_codec);
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (DungeonGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeon other) {
      if (other == null) {
        return;
      }
      if (other.setting_ != null) {
        if (setting_ == null) {
          Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting();
        }
        Setting.MergeFrom(other.Setting);
      }
      roomList_.Add(other.roomList_);
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.DungeonGuid != 0UL) {
        DungeonGuid = other.DungeonGuid;
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
          case 10: {
            if (setting_ == null) {
              Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 24: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 80: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 122: {
            roomList_.AddEntriesFrom(input, _repeated_roomList_codec);
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
          case 10: {
            if (setting_ == null) {
              Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 24: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 80: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 122: {
            roomList_.AddEntriesFrom(ref input, _repeated_roomList_codec);
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
