// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: pyrfuniverse/communicator_objects/unity_input.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Robotflow.RFUniverse.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from pyrfuniverse/communicator_objects/unity_input.proto</summary>
  internal static partial class UnityInputReflection {

    #region Descriptor
    /// <summary>File descriptor for pyrfuniverse/communicator_objects/unity_input.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityInputReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNweXJmdW5pdmVyc2UvY29tbXVuaWNhdG9yX29iamVjdHMvdW5pdHlfaW5w",
            "dXQucHJvdG8SFGNvbW11bmljYXRvcl9vYmplY3RzGjZweXJmdW5pdmVyc2Uv",
            "Y29tbXVuaWNhdG9yX29iamVjdHMvdW5pdHlfcmxfaW5wdXQucHJvdG8aRXB5",
            "cmZ1bml2ZXJzZS9jb21tdW5pY2F0b3Jfb2JqZWN0cy91bml0eV9ybF9pbml0",
            "aWFsaXphdGlvbl9pbnB1dC5wcm90byKkAQoPVW5pdHlJbnB1dFByb3RvEjkK",
            "CHJsX2lucHV0GAEgASgLMicuY29tbXVuaWNhdG9yX29iamVjdHMuVW5pdHlS",
            "TElucHV0UHJvdG8SVgoXcmxfaW5pdGlhbGl6YXRpb25faW5wdXQYAiABKAsy",
            "NS5jb21tdW5pY2F0b3Jfb2JqZWN0cy5Vbml0eVJMSW5pdGlhbGl6YXRpb25J",
            "bnB1dFByb3RvQiuqAihSb2JvdGZsb3cuUkZVbml2ZXJzZS5Db21tdW5pY2F0",
            "b3JPYmplY3RzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Robotflow.RFUniverse.CommunicatorObjects.UnityRlInputReflection.Descriptor, global::Robotflow.RFUniverse.CommunicatorObjects.UnityRlInitializationInputReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Robotflow.RFUniverse.CommunicatorObjects.UnityInputProto), global::Robotflow.RFUniverse.CommunicatorObjects.UnityInputProto.Parser, new[]{ "RlInput", "RlInitializationInput" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class UnityInputProto : pb::IMessage<UnityInputProto> {
    private static readonly pb::MessageParser<UnityInputProto> _parser = new pb::MessageParser<UnityInputProto>(() => new UnityInputProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityInputProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Robotflow.RFUniverse.CommunicatorObjects.UnityInputReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityInputProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityInputProto(UnityInputProto other) : this() {
      RlInput = other.rlInput_ != null ? other.RlInput.Clone() : null;
      RlInitializationInput = other.rlInitializationInput_ != null ? other.RlInitializationInput.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityInputProto Clone() {
      return new UnityInputProto(this);
    }

    /// <summary>Field number for the "rl_input" field.</summary>
    public const int RlInputFieldNumber = 1;
    private global::Robotflow.RFUniverse.CommunicatorObjects.UnityRLInputProto rlInput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Robotflow.RFUniverse.CommunicatorObjects.UnityRLInputProto RlInput {
      get { return rlInput_; }
      set {
        rlInput_ = value;
      }
    }

    /// <summary>Field number for the "rl_initialization_input" field.</summary>
    public const int RlInitializationInputFieldNumber = 2;
    private global::Robotflow.RFUniverse.CommunicatorObjects.UnityRLInitializationInputProto rlInitializationInput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Robotflow.RFUniverse.CommunicatorObjects.UnityRLInitializationInputProto RlInitializationInput {
      get { return rlInitializationInput_; }
      set {
        rlInitializationInput_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityInputProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityInputProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RlInput, other.RlInput)) return false;
      if (!object.Equals(RlInitializationInput, other.RlInitializationInput)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rlInput_ != null) hash ^= RlInput.GetHashCode();
      if (rlInitializationInput_ != null) hash ^= RlInitializationInput.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (rlInput_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RlInput);
      }
      if (rlInitializationInput_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RlInitializationInput);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rlInput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RlInput);
      }
      if (rlInitializationInput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RlInitializationInput);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityInputProto other) {
      if (other == null) {
        return;
      }
      if (other.rlInput_ != null) {
        if (rlInput_ == null) {
          rlInput_ = new global::Robotflow.RFUniverse.CommunicatorObjects.UnityRLInputProto();
        }
        RlInput.MergeFrom(other.RlInput);
      }
      if (other.rlInitializationInput_ != null) {
        if (rlInitializationInput_ == null) {
          rlInitializationInput_ = new global::Robotflow.RFUniverse.CommunicatorObjects.UnityRLInitializationInputProto();
        }
        RlInitializationInput.MergeFrom(other.RlInitializationInput);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (rlInput_ == null) {
              rlInput_ = new global::Robotflow.RFUniverse.CommunicatorObjects.UnityRLInputProto();
            }
            input.ReadMessage(rlInput_);
            break;
          }
          case 18: {
            if (rlInitializationInput_ == null) {
              rlInitializationInput_ = new global::Robotflow.RFUniverse.CommunicatorObjects.UnityRLInitializationInputProto();
            }
            input.ReadMessage(rlInitializationInput_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
