// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TanukiTravelLevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TanukiTravelLevelData.proto</summary>
  public static partial class TanukiTravelLevelDataReflection {

    #region Descriptor
    /// <summary>File descriptor for TanukiTravelLevelData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TanukiTravelLevelDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtUYW51a2lUcmF2ZWxMZXZlbERhdGEucHJvdG8iTQoVVGFudWtpVHJhdmVs",
            "TGV2ZWxEYXRhEg8KB2lzX29wZW4YBSABKAgSEAoIcm91dGVfaWQYCSABKA0S",
            "EQoJaXNfZmluaXNoGA8gASgIQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelData), global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelData.Parser, new[]{ "IsOpen", "RouteId", "IsFinish" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TanukiTravelLevelData : pb::IMessage<TanukiTravelLevelData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TanukiTravelLevelData> _parser = new pb::MessageParser<TanukiTravelLevelData>(() => new TanukiTravelLevelData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TanukiTravelLevelData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelLevelData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelLevelData(TanukiTravelLevelData other) : this() {
      isOpen_ = other.isOpen_;
      routeId_ = other.routeId_;
      isFinish_ = other.isFinish_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelLevelData Clone() {
      return new TanukiTravelLevelData(this);
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 5;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "route_id" field.</summary>
    public const int RouteIdFieldNumber = 9;
    private uint routeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RouteId {
      get { return routeId_; }
      set {
        routeId_ = value;
      }
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 15;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TanukiTravelLevelData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TanukiTravelLevelData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsOpen != other.IsOpen) return false;
      if (RouteId != other.RouteId) return false;
      if (IsFinish != other.IsFinish) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (RouteId != 0) hash ^= RouteId.GetHashCode();
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
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
      if (IsOpen != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsOpen);
      }
      if (RouteId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RouteId);
      }
      if (IsFinish != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsFinish);
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
      if (IsOpen != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsOpen);
      }
      if (RouteId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RouteId);
      }
      if (IsFinish != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsFinish);
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
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (RouteId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RouteId);
      }
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TanukiTravelLevelData other) {
      if (other == null) {
        return;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.RouteId != 0) {
        RouteId = other.RouteId;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
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
          case 40: {
            IsOpen = input.ReadBool();
            break;
          }
          case 72: {
            RouteId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsFinish = input.ReadBool();
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
          case 40: {
            IsOpen = input.ReadBool();
            break;
          }
          case 72: {
            RouteId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsFinish = input.ReadBool();
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
