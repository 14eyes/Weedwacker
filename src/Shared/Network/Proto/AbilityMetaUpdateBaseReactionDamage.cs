// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMetaUpdateBaseReactionDamage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AbilityMetaUpdateBaseReactionDamage.proto</summary>
  public static partial class AbilityMetaUpdateBaseReactionDamageReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityMetaUpdateBaseReactionDamage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityMetaUpdateBaseReactionDamageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilBYmlsaXR5TWV0YVVwZGF0ZUJhc2VSZWFjdGlvbkRhbWFnZS5wcm90bxoT",
            "QWJpbGl0eVN0cmluZy5wcm90byKmAQojQWJpbGl0eU1ldGFVcGRhdGVCYXNl",
            "UmVhY3Rpb25EYW1hZ2USGAoQc291cmNlX2Nhc3Rlcl9pZBgPIAEoDRIkCgxh",
            "YmlsaXR5X25hbWUYASABKAsyDi5BYmlsaXR5U3RyaW5nEigKEGdsb2JhbF92",
            "YWx1ZV9rZXkYBCABKAsyDi5BYmlsaXR5U3RyaW5nEhUKDXJlYWN0aW9uX3R5",
            "cGUYCCABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AbilityStringReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AbilityMetaUpdateBaseReactionDamage), global::Weedwacker.Shared.Network.Proto.AbilityMetaUpdateBaseReactionDamage.Parser, new[]{ "SourceCasterId", "AbilityName", "GlobalValueKey", "ReactionType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityMetaUpdateBaseReactionDamage : pb::IMessage<AbilityMetaUpdateBaseReactionDamage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityMetaUpdateBaseReactionDamage> _parser = new pb::MessageParser<AbilityMetaUpdateBaseReactionDamage>(() => new AbilityMetaUpdateBaseReactionDamage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityMetaUpdateBaseReactionDamage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AbilityMetaUpdateBaseReactionDamageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMetaUpdateBaseReactionDamage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMetaUpdateBaseReactionDamage(AbilityMetaUpdateBaseReactionDamage other) : this() {
      sourceCasterId_ = other.sourceCasterId_;
      abilityName_ = other.abilityName_ != null ? other.abilityName_.Clone() : null;
      globalValueKey_ = other.globalValueKey_ != null ? other.globalValueKey_.Clone() : null;
      reactionType_ = other.reactionType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMetaUpdateBaseReactionDamage Clone() {
      return new AbilityMetaUpdateBaseReactionDamage(this);
    }

    /// <summary>Field number for the "source_caster_id" field.</summary>
    public const int SourceCasterIdFieldNumber = 15;
    private uint sourceCasterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceCasterId {
      get { return sourceCasterId_; }
      set {
        sourceCasterId_ = value;
      }
    }

    /// <summary>Field number for the "ability_name" field.</summary>
    public const int AbilityNameFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.AbilityString abilityName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AbilityString AbilityName {
      get { return abilityName_; }
      set {
        abilityName_ = value;
      }
    }

    /// <summary>Field number for the "global_value_key" field.</summary>
    public const int GlobalValueKeyFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.AbilityString globalValueKey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AbilityString GlobalValueKey {
      get { return globalValueKey_; }
      set {
        globalValueKey_ = value;
      }
    }

    /// <summary>Field number for the "reaction_type" field.</summary>
    public const int ReactionTypeFieldNumber = 8;
    private uint reactionType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReactionType {
      get { return reactionType_; }
      set {
        reactionType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityMetaUpdateBaseReactionDamage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityMetaUpdateBaseReactionDamage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceCasterId != other.SourceCasterId) return false;
      if (!object.Equals(AbilityName, other.AbilityName)) return false;
      if (!object.Equals(GlobalValueKey, other.GlobalValueKey)) return false;
      if (ReactionType != other.ReactionType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceCasterId != 0) hash ^= SourceCasterId.GetHashCode();
      if (abilityName_ != null) hash ^= AbilityName.GetHashCode();
      if (globalValueKey_ != null) hash ^= GlobalValueKey.GetHashCode();
      if (ReactionType != 0) hash ^= ReactionType.GetHashCode();
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
      if (abilityName_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AbilityName);
      }
      if (globalValueKey_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GlobalValueKey);
      }
      if (ReactionType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ReactionType);
      }
      if (SourceCasterId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SourceCasterId);
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
      if (abilityName_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AbilityName);
      }
      if (globalValueKey_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GlobalValueKey);
      }
      if (ReactionType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ReactionType);
      }
      if (SourceCasterId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SourceCasterId);
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
      if (SourceCasterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceCasterId);
      }
      if (abilityName_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbilityName);
      }
      if (globalValueKey_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GlobalValueKey);
      }
      if (ReactionType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ReactionType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityMetaUpdateBaseReactionDamage other) {
      if (other == null) {
        return;
      }
      if (other.SourceCasterId != 0) {
        SourceCasterId = other.SourceCasterId;
      }
      if (other.abilityName_ != null) {
        if (abilityName_ == null) {
          AbilityName = new global::Weedwacker.Shared.Network.Proto.AbilityString();
        }
        AbilityName.MergeFrom(other.AbilityName);
      }
      if (other.globalValueKey_ != null) {
        if (globalValueKey_ == null) {
          GlobalValueKey = new global::Weedwacker.Shared.Network.Proto.AbilityString();
        }
        GlobalValueKey.MergeFrom(other.GlobalValueKey);
      }
      if (other.ReactionType != 0) {
        ReactionType = other.ReactionType;
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
            if (abilityName_ == null) {
              AbilityName = new global::Weedwacker.Shared.Network.Proto.AbilityString();
            }
            input.ReadMessage(AbilityName);
            break;
          }
          case 34: {
            if (globalValueKey_ == null) {
              GlobalValueKey = new global::Weedwacker.Shared.Network.Proto.AbilityString();
            }
            input.ReadMessage(GlobalValueKey);
            break;
          }
          case 64: {
            ReactionType = input.ReadUInt32();
            break;
          }
          case 120: {
            SourceCasterId = input.ReadUInt32();
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
            if (abilityName_ == null) {
              AbilityName = new global::Weedwacker.Shared.Network.Proto.AbilityString();
            }
            input.ReadMessage(AbilityName);
            break;
          }
          case 34: {
            if (globalValueKey_ == null) {
              GlobalValueKey = new global::Weedwacker.Shared.Network.Proto.AbilityString();
            }
            input.ReadMessage(GlobalValueKey);
            break;
          }
          case 64: {
            ReactionType = input.ReadUInt32();
            break;
          }
          case 120: {
            SourceCasterId = input.ReadUInt32();
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
