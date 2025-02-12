// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetInteractReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GadgetInteractReq.proto</summary>
  public static partial class GadgetInteractReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GadgetInteractReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GadgetInteractReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHYWRnZXRJbnRlcmFjdFJlcS5wcm90bxoRSW50ZXJPcFR5cGUucHJvdG8a",
            "E1Jlc2luQ29zdFR5cGUucHJvdG8ivwEKEUdhZGdldEludGVyYWN0UmVxEhEK",
            "CWdhZGdldF9pZBgIIAEoDRIdChVpc191c2VfY29uZGVuc2VfcmVzaW4YDyAB",
            "KAgSHQoHb3BfdHlwZRgFIAEoDjIMLkludGVyT3BUeXBlEicKD3Jlc2luX2Nv",
            "c3RfdHlwZRgBIAEoDjIOLlJlc2luQ29zdFR5cGUSFgoOdWlfaW50ZXJhY3Rf",
            "aWQYAiABKA0SGAoQZ2FkZ2V0X2VudGl0eV9pZBgEIAEoDUIiqgIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.InterOpTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ResinCostTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GadgetInteractReq), global::Weedwacker.Shared.Network.Proto.GadgetInteractReq.Parser, new[]{ "GadgetId", "IsUseCondenseResin", "OpType", "ResinCostType", "UiInteractId", "GadgetEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 872
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class GadgetInteractReq : pb::IMessage<GadgetInteractReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GadgetInteractReq> _parser = new pb::MessageParser<GadgetInteractReq>(() => new GadgetInteractReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GadgetInteractReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GadgetInteractReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetInteractReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetInteractReq(GadgetInteractReq other) : this() {
      gadgetId_ = other.gadgetId_;
      isUseCondenseResin_ = other.isUseCondenseResin_;
      opType_ = other.opType_;
      resinCostType_ = other.resinCostType_;
      uiInteractId_ = other.uiInteractId_;
      gadgetEntityId_ = other.gadgetEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetInteractReq Clone() {
      return new GadgetInteractReq(this);
    }

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 8;
    private uint gadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return gadgetId_; }
      set {
        gadgetId_ = value;
      }
    }

    /// <summary>Field number for the "is_use_condense_resin" field.</summary>
    public const int IsUseCondenseResinFieldNumber = 15;
    private bool isUseCondenseResin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUseCondenseResin {
      get { return isUseCondenseResin_; }
      set {
        isUseCondenseResin_ = value;
      }
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.InterOpType opType_ = global::Weedwacker.Shared.Network.Proto.InterOpType.Finish;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.InterOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    /// <summary>Field number for the "resin_cost_type" field.</summary>
    public const int ResinCostTypeFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.ResinCostType resinCostType_ = global::Weedwacker.Shared.Network.Proto.ResinCostType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ResinCostType ResinCostType {
      get { return resinCostType_; }
      set {
        resinCostType_ = value;
      }
    }

    /// <summary>Field number for the "ui_interact_id" field.</summary>
    public const int UiInteractIdFieldNumber = 2;
    private uint uiInteractId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UiInteractId {
      get { return uiInteractId_; }
      set {
        uiInteractId_ = value;
      }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 4;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GadgetInteractReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GadgetInteractReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GadgetId != other.GadgetId) return false;
      if (IsUseCondenseResin != other.IsUseCondenseResin) return false;
      if (OpType != other.OpType) return false;
      if (ResinCostType != other.ResinCostType) return false;
      if (UiInteractId != other.UiInteractId) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
      if (IsUseCondenseResin != false) hash ^= IsUseCondenseResin.GetHashCode();
      if (OpType != global::Weedwacker.Shared.Network.Proto.InterOpType.Finish) hash ^= OpType.GetHashCode();
      if (ResinCostType != global::Weedwacker.Shared.Network.Proto.ResinCostType.None) hash ^= ResinCostType.GetHashCode();
      if (UiInteractId != 0) hash ^= UiInteractId.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
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
      if (ResinCostType != global::Weedwacker.Shared.Network.Proto.ResinCostType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ResinCostType);
      }
      if (UiInteractId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UiInteractId);
      }
      if (GadgetEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GadgetEntityId);
      }
      if (OpType != global::Weedwacker.Shared.Network.Proto.InterOpType.Finish) {
        output.WriteRawTag(40);
        output.WriteEnum((int) OpType);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GadgetId);
      }
      if (IsUseCondenseResin != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsUseCondenseResin);
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
      if (ResinCostType != global::Weedwacker.Shared.Network.Proto.ResinCostType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ResinCostType);
      }
      if (UiInteractId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UiInteractId);
      }
      if (GadgetEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GadgetEntityId);
      }
      if (OpType != global::Weedwacker.Shared.Network.Proto.InterOpType.Finish) {
        output.WriteRawTag(40);
        output.WriteEnum((int) OpType);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GadgetId);
      }
      if (IsUseCondenseResin != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsUseCondenseResin);
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
      if (GadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      if (IsUseCondenseResin != false) {
        size += 1 + 1;
      }
      if (OpType != global::Weedwacker.Shared.Network.Proto.InterOpType.Finish) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (ResinCostType != global::Weedwacker.Shared.Network.Proto.ResinCostType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResinCostType);
      }
      if (UiInteractId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UiInteractId);
      }
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GadgetInteractReq other) {
      if (other == null) {
        return;
      }
      if (other.GadgetId != 0) {
        GadgetId = other.GadgetId;
      }
      if (other.IsUseCondenseResin != false) {
        IsUseCondenseResin = other.IsUseCondenseResin;
      }
      if (other.OpType != global::Weedwacker.Shared.Network.Proto.InterOpType.Finish) {
        OpType = other.OpType;
      }
      if (other.ResinCostType != global::Weedwacker.Shared.Network.Proto.ResinCostType.None) {
        ResinCostType = other.ResinCostType;
      }
      if (other.UiInteractId != 0) {
        UiInteractId = other.UiInteractId;
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
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
            ResinCostType = (global::Weedwacker.Shared.Network.Proto.ResinCostType) input.ReadEnum();
            break;
          }
          case 16: {
            UiInteractId = input.ReadUInt32();
            break;
          }
          case 32: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            OpType = (global::Weedwacker.Shared.Network.Proto.InterOpType) input.ReadEnum();
            break;
          }
          case 64: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsUseCondenseResin = input.ReadBool();
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
            ResinCostType = (global::Weedwacker.Shared.Network.Proto.ResinCostType) input.ReadEnum();
            break;
          }
          case 16: {
            UiInteractId = input.ReadUInt32();
            break;
          }
          case 32: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            OpType = (global::Weedwacker.Shared.Network.Proto.InterOpType) input.ReadEnum();
            break;
          }
          case 64: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsUseCondenseResin = input.ReadBool();
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
