// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgAddCards.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGMsgAddCards.proto</summary>
  public static partial class GCGMsgAddCardsReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgAddCards.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgAddCardsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRHQ0dNc2dBZGRDYXJkcy5wcm90bxoPR0NHUmVhc29uLnByb3RvGhFHQ0da",
            "b25lVHlwZS5wcm90byKEAQoOR0NHTXNnQWRkQ2FyZHMSCwoDcG9zGAsgASgN",
            "EhoKBHpvbmUYAiABKA4yDC5HQ0dab25lVHlwZRIaCgZyZWFzb24YDyABKA4y",
            "Ci5HQ0dSZWFzb24SFQoNY29udHJvbGxlcl9pZBgNIAEoDRIWCg5jYXJkX2d1",
            "aWRfbGlzdBgOIAMoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGReasonReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGZoneTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGMsgAddCards), global::Weedwacker.Shared.Network.Proto.GCGMsgAddCards.Parser, new[]{ "Pos", "Zone", "Reason", "ControllerId", "CardGuidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgAddCards : pb::IMessage<GCGMsgAddCards>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgAddCards> _parser = new pb::MessageParser<GCGMsgAddCards>(() => new GCGMsgAddCards());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgAddCards> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGMsgAddCardsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddCards() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddCards(GCGMsgAddCards other) : this() {
      pos_ = other.pos_;
      zone_ = other.zone_;
      reason_ = other.reason_;
      controllerId_ = other.controllerId_;
      cardGuidList_ = other.cardGuidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddCards Clone() {
      return new GCGMsgAddCards(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 11;
    private uint pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "zone" field.</summary>
    public const int ZoneFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.GCGZoneType zone_ = global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGZoneType Zone {
      get { return zone_; }
      set {
        zone_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.GCGReason reason_ = global::Weedwacker.Shared.Network.Proto.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 13;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "card_guid_list" field.</summary>
    public const int CardGuidListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_cardGuidList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> cardGuidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardGuidList {
      get { return cardGuidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgAddCards);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgAddCards other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Pos != other.Pos) return false;
      if (Zone != other.Zone) return false;
      if (Reason != other.Reason) return false;
      if (ControllerId != other.ControllerId) return false;
      if(!cardGuidList_.Equals(other.cardGuidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Pos != 0) hash ^= Pos.GetHashCode();
      if (Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) hash ^= Zone.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) hash ^= Reason.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      hash ^= cardGuidList_.GetHashCode();
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
      if (Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Zone);
      }
      if (Pos != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Pos);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ControllerId);
      }
      cardGuidList_.WriteTo(output, _repeated_cardGuidList_codec);
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(120);
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
      if (Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Zone);
      }
      if (Pos != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Pos);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ControllerId);
      }
      cardGuidList_.WriteTo(ref output, _repeated_cardGuidList_codec);
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(120);
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
      if (Pos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
      }
      if (Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Zone);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      size += cardGuidList_.CalculateSize(_repeated_cardGuidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgAddCards other) {
      if (other == null) {
        return;
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
      }
      if (other.Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        Zone = other.Zone;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        Reason = other.Reason;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      cardGuidList_.Add(other.cardGuidList_);
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
            Zone = (global::Weedwacker.Shared.Network.Proto.GCGZoneType) input.ReadEnum();
            break;
          }
          case 88: {
            Pos = input.ReadUInt32();
            break;
          }
          case 104: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            cardGuidList_.AddEntriesFrom(input, _repeated_cardGuidList_codec);
            break;
          }
          case 120: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
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
            Zone = (global::Weedwacker.Shared.Network.Proto.GCGZoneType) input.ReadEnum();
            break;
          }
          case 88: {
            Pos = input.ReadUInt32();
            break;
          }
          case 104: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            cardGuidList_.AddEntriesFrom(ref input, _repeated_cardGuidList_codec);
            break;
          }
          case 120: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
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
