// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerQuitFromMpNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerQuitFromMpNotify.proto</summary>
  public static partial class PlayerQuitFromMpNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerQuitFromMpNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerQuitFromMpNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQbGF5ZXJRdWl0RnJvbU1wTm90aWZ5LnByb3RvIuUDChZQbGF5ZXJRdWl0",
            "RnJvbU1wTm90aWZ5EjIKBnJlYXNvbhgLIAEoDjIiLlBsYXllclF1aXRGcm9t",
            "TXBOb3RpZnkuUXVpdFJlYXNvbiKWAwoKUXVpdFJlYXNvbhIXChNRVUlUX1JF",
            "QVNPTl9JTlZBTElEEAASJAogUVVJVF9SRUFTT05fSE9TVF9OT19PVEhFUl9Q",
            "TEFZRVIQARIcChhRVUlUX1JFQVNPTl9LSUNLX0JZX0hPU1QQAhIgChxRVUlU",
            "X1JFQVNPTl9CQUNLX1RPX01ZX1dPUkxEEAMSIwofUVVJVF9SRUFTT05fS0lD",
            "S19CWV9IT1NUX0xPR09VVBAEEiIKHlFVSVRfUkVBU09OX0tJQ0tfQllfSE9T",
            "VF9CTE9DSxAFEhoKFlFVSVRfUkVBU09OX0JFX0JMT0NLRUQQBhInCiNRVUlU",
            "X1JFQVNPTl9LSUNLX0JZX0hPU1RfRU5URVJfSE9NRRAHEiIKHlFVSVRfUkVB",
            "U09OX0hPU1RfU0NFTkVfSU5WQUxJRBAIEhwKGFFVSVRfUkVBU09OX0tJQ0tf",
            "QllfUExBWRAJEjkKNVFVSVRfUkVBU09OX0tJQ0tfQllfSVNMQU5EX1BBUlRZ",
            "X0dBTExFUllfU1RBUlRfRkFJTEVEEApCIqoCH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify), global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Parser, new[]{ "Reason" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1829
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerQuitFromMpNotify : pb::IMessage<PlayerQuitFromMpNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerQuitFromMpNotify> _parser = new pb::MessageParser<PlayerQuitFromMpNotify>(() => new PlayerQuitFromMpNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerQuitFromMpNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerQuitFromMpNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerQuitFromMpNotify(PlayerQuitFromMpNotify other) : this() {
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerQuitFromMpNotify Clone() {
      return new PlayerQuitFromMpNotify(this);
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason reason_ = global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerQuitFromMpNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerQuitFromMpNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Reason != global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason.Invalid) hash ^= Reason.GetHashCode();
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
      if (Reason != global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason.Invalid) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
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
      if (Reason != global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason.Invalid) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
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
      if (Reason != global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerQuitFromMpNotify other) {
      if (other == null) {
        return;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason.Invalid) {
        Reason = other.Reason;
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
          case 88: {
            Reason = (global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason) input.ReadEnum();
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
          case 88: {
            Reason = (global::Weedwacker.Shared.Network.Proto.PlayerQuitFromMpNotify.Types.QuitReason) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerQuitFromMpNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum QuitReason {
        [pbr::OriginalName("QUIT_REASON_INVALID")] Invalid = 0,
        [pbr::OriginalName("QUIT_REASON_HOST_NO_OTHER_PLAYER")] HostNoOtherPlayer = 1,
        [pbr::OriginalName("QUIT_REASON_KICK_BY_HOST")] KickByHost = 2,
        [pbr::OriginalName("QUIT_REASON_BACK_TO_MY_WORLD")] BackToMyWorld = 3,
        [pbr::OriginalName("QUIT_REASON_KICK_BY_HOST_LOGOUT")] KickByHostLogout = 4,
        [pbr::OriginalName("QUIT_REASON_KICK_BY_HOST_BLOCK")] KickByHostBlock = 5,
        [pbr::OriginalName("QUIT_REASON_BE_BLOCKED")] BeBlocked = 6,
        [pbr::OriginalName("QUIT_REASON_KICK_BY_HOST_ENTER_HOME")] KickByHostEnterHome = 7,
        [pbr::OriginalName("QUIT_REASON_HOST_SCENE_INVALID")] HostSceneInvalid = 8,
        [pbr::OriginalName("QUIT_REASON_KICK_BY_PLAY")] KickByPlay = 9,
        [pbr::OriginalName("QUIT_REASON_KICK_BY_ISLAND_PARTY_GALLERY_START_FAILED")] KickByIslandPartyGalleryStartFailed = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
