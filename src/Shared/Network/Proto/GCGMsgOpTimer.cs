// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgOpTimer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGMsgOpTimer.proto</summary>
  public static partial class GCGMsgOpTimerReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgOpTimer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgOpTimerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNHQ0dNc2dPcFRpbWVyLnByb3RvGhJHQ0dQaGFzZVR5cGUucHJvdG8ibAoN",
            "R0NHTXNnT3BUaW1lchISCgpiZWdpbl90aW1lGAkgASgGEhwKBXBoYXNlGAMg",
            "ASgOMg0uR0NHUGhhc2VUeXBlEhIKCnRpbWVfc3RhbXAYDSABKAYSFQoNY29u",
            "dHJvbGxlcl9pZBgIIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGPhaseTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGMsgOpTimer), global::Weedwacker.Shared.Network.Proto.GCGMsgOpTimer.Parser, new[]{ "BeginTime", "Phase", "TimeStamp", "ControllerId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgOpTimer : pb::IMessage<GCGMsgOpTimer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgOpTimer> _parser = new pb::MessageParser<GCGMsgOpTimer>(() => new GCGMsgOpTimer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgOpTimer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGMsgOpTimerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgOpTimer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgOpTimer(GCGMsgOpTimer other) : this() {
      beginTime_ = other.beginTime_;
      phase_ = other.phase_;
      timeStamp_ = other.timeStamp_;
      controllerId_ = other.controllerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgOpTimer Clone() {
      return new GCGMsgOpTimer(this);
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 9;
    private ulong beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "phase" field.</summary>
    public const int PhaseFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.GCGPhaseType phase_ = global::Weedwacker.Shared.Network.Proto.GCGPhaseType.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGPhaseType Phase {
      get { return phase_; }
      set {
        phase_ = value;
      }
    }

    /// <summary>Field number for the "time_stamp" field.</summary>
    public const int TimeStampFieldNumber = 13;
    private ulong timeStamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TimeStamp {
      get { return timeStamp_; }
      set {
        timeStamp_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 8;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgOpTimer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgOpTimer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BeginTime != other.BeginTime) return false;
      if (Phase != other.Phase) return false;
      if (TimeStamp != other.TimeStamp) return false;
      if (ControllerId != other.ControllerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BeginTime != 0UL) hash ^= BeginTime.GetHashCode();
      if (Phase != global::Weedwacker.Shared.Network.Proto.GCGPhaseType.Invalid) hash ^= Phase.GetHashCode();
      if (TimeStamp != 0UL) hash ^= TimeStamp.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
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
      if (Phase != global::Weedwacker.Shared.Network.Proto.GCGPhaseType.Invalid) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Phase);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ControllerId);
      }
      if (BeginTime != 0UL) {
        output.WriteRawTag(73);
        output.WriteFixed64(BeginTime);
      }
      if (TimeStamp != 0UL) {
        output.WriteRawTag(105);
        output.WriteFixed64(TimeStamp);
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
      if (Phase != global::Weedwacker.Shared.Network.Proto.GCGPhaseType.Invalid) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Phase);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ControllerId);
      }
      if (BeginTime != 0UL) {
        output.WriteRawTag(73);
        output.WriteFixed64(BeginTime);
      }
      if (TimeStamp != 0UL) {
        output.WriteRawTag(105);
        output.WriteFixed64(TimeStamp);
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
      if (BeginTime != 0UL) {
        size += 1 + 8;
      }
      if (Phase != global::Weedwacker.Shared.Network.Proto.GCGPhaseType.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Phase);
      }
      if (TimeStamp != 0UL) {
        size += 1 + 8;
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgOpTimer other) {
      if (other == null) {
        return;
      }
      if (other.BeginTime != 0UL) {
        BeginTime = other.BeginTime;
      }
      if (other.Phase != global::Weedwacker.Shared.Network.Proto.GCGPhaseType.Invalid) {
        Phase = other.Phase;
      }
      if (other.TimeStamp != 0UL) {
        TimeStamp = other.TimeStamp;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
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
          case 24: {
            Phase = (global::Weedwacker.Shared.Network.Proto.GCGPhaseType) input.ReadEnum();
            break;
          }
          case 64: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 73: {
            BeginTime = input.ReadFixed64();
            break;
          }
          case 105: {
            TimeStamp = input.ReadFixed64();
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
          case 24: {
            Phase = (global::Weedwacker.Shared.Network.Proto.GCGPhaseType) input.ReadEnum();
            break;
          }
          case 64: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 73: {
            BeginTime = input.ReadFixed64();
            break;
          }
          case 105: {
            TimeStamp = input.ReadFixed64();
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
