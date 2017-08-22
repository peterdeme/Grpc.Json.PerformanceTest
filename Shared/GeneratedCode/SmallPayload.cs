// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: SmallPayload.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SmallPayload.proto</summary>
public static partial class SmallPayloadReflection {

  #region Descriptor
  /// <summary>File descriptor for SmallPayload.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SmallPayloadReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChJTbWFsbFBheWxvYWQucHJvdG8iHwoMU21hbGxSZXF1ZXN0Eg8KB01lc3Nh",
          "Z2UYASABKAkiIAoNU21hbGxSZXNwb25zZRIPCgdNZXNzYWdlGAEgASgJMkgK",
          "E1NtYWxsUGF5bG9hZFNlcnZpY2USMQoQU2VuZFNtYWxsUGF5bG9hZBINLlNt",
          "YWxsUmVxdWVzdBoOLlNtYWxsUmVzcG9uc2ViBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SmallRequest), global::SmallRequest.Parser, new[]{ "Message" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SmallResponse), global::SmallResponse.Parser, new[]{ "Message" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SmallRequest : pb::IMessage<SmallRequest> {
  private static readonly pb::MessageParser<SmallRequest> _parser = new pb::MessageParser<SmallRequest>(() => new SmallRequest());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SmallRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SmallPayloadReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SmallRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SmallRequest(SmallRequest other) : this() {
    message_ = other.message_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SmallRequest Clone() {
    return new SmallRequest(this);
  }

  /// <summary>Field number for the "Message" field.</summary>
  public const int MessageFieldNumber = 1;
  private string message_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SmallRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SmallRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Message != other.Message) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Message);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SmallRequest other) {
    if (other == null) {
      return;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          Message = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class SmallResponse : pb::IMessage<SmallResponse> {
  private static readonly pb::MessageParser<SmallResponse> _parser = new pb::MessageParser<SmallResponse>(() => new SmallResponse());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SmallResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SmallPayloadReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SmallResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SmallResponse(SmallResponse other) : this() {
    message_ = other.message_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SmallResponse Clone() {
    return new SmallResponse(this);
  }

  /// <summary>Field number for the "Message" field.</summary>
  public const int MessageFieldNumber = 1;
  private string message_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SmallResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SmallResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Message != other.Message) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Message);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SmallResponse other) {
    if (other == null) {
      return;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          Message = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
