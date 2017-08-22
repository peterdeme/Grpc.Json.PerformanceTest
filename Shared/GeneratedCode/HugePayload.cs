// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: HugePayload.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HugePayload.proto</summary>
public static partial class HugePayloadReflection {

  #region Descriptor
  /// <summary>File descriptor for HugePayload.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HugePayloadReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFIdWdlUGF5bG9hZC5wcm90byIyCgtIdWdlUmVxdWVzdBISCgpTdHJpbmdM",
          "aXN0GAEgAygJEg8KB0ludExpc3QYAiADKAUiMwoMSHVnZVJlc3BvbnNlEhIK",
          "ClN0cmluZ0xpc3QYASADKAkSDwoHSW50TGlzdBgCIAMoBTJEChJIdWdlUGF5",
          "bG9hZFNlcnZpY2USLgoPU2VuZEh1Z2VQYXlsb2FkEgwuSHVnZVJlcXVlc3Qa",
          "DS5IdWdlUmVzcG9uc2ViBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HugeRequest), global::HugeRequest.Parser, new[]{ "StringList", "IntList" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::HugeResponse), global::HugeResponse.Parser, new[]{ "StringList", "IntList" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class HugeRequest : pb::IMessage<HugeRequest> {
  private static readonly pb::MessageParser<HugeRequest> _parser = new pb::MessageParser<HugeRequest>(() => new HugeRequest());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<HugeRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HugePayloadReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HugeRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HugeRequest(HugeRequest other) : this() {
    stringList_ = other.stringList_.Clone();
    intList_ = other.intList_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HugeRequest Clone() {
    return new HugeRequest(this);
  }

  /// <summary>Field number for the "StringList" field.</summary>
  public const int StringListFieldNumber = 1;
  private static readonly pb::FieldCodec<string> _repeated_stringList_codec
      = pb::FieldCodec.ForString(10);
  private readonly pbc::RepeatedField<string> stringList_ = new pbc::RepeatedField<string>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<string> StringList {
    get { return stringList_; }
  }

  /// <summary>Field number for the "IntList" field.</summary>
  public const int IntListFieldNumber = 2;
  private static readonly pb::FieldCodec<int> _repeated_intList_codec
      = pb::FieldCodec.ForInt32(18);
  private readonly pbc::RepeatedField<int> intList_ = new pbc::RepeatedField<int>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<int> IntList {
    get { return intList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as HugeRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(HugeRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!stringList_.Equals(other.stringList_)) return false;
    if(!intList_.Equals(other.intList_)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= stringList_.GetHashCode();
    hash ^= intList_.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    stringList_.WriteTo(output, _repeated_stringList_codec);
    intList_.WriteTo(output, _repeated_intList_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += stringList_.CalculateSize(_repeated_stringList_codec);
    size += intList_.CalculateSize(_repeated_intList_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(HugeRequest other) {
    if (other == null) {
      return;
    }
    stringList_.Add(other.stringList_);
    intList_.Add(other.intList_);
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
          stringList_.AddEntriesFrom(input, _repeated_stringList_codec);
          break;
        }
        case 18:
        case 16: {
          intList_.AddEntriesFrom(input, _repeated_intList_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class HugeResponse : pb::IMessage<HugeResponse> {
  private static readonly pb::MessageParser<HugeResponse> _parser = new pb::MessageParser<HugeResponse>(() => new HugeResponse());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<HugeResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HugePayloadReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HugeResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HugeResponse(HugeResponse other) : this() {
    stringList_ = other.stringList_.Clone();
    intList_ = other.intList_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HugeResponse Clone() {
    return new HugeResponse(this);
  }

  /// <summary>Field number for the "StringList" field.</summary>
  public const int StringListFieldNumber = 1;
  private static readonly pb::FieldCodec<string> _repeated_stringList_codec
      = pb::FieldCodec.ForString(10);
  private readonly pbc::RepeatedField<string> stringList_ = new pbc::RepeatedField<string>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<string> StringList {
    get { return stringList_; }
  }

  /// <summary>Field number for the "IntList" field.</summary>
  public const int IntListFieldNumber = 2;
  private static readonly pb::FieldCodec<int> _repeated_intList_codec
      = pb::FieldCodec.ForInt32(18);
  private readonly pbc::RepeatedField<int> intList_ = new pbc::RepeatedField<int>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<int> IntList {
    get { return intList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as HugeResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(HugeResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!stringList_.Equals(other.stringList_)) return false;
    if(!intList_.Equals(other.intList_)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= stringList_.GetHashCode();
    hash ^= intList_.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    stringList_.WriteTo(output, _repeated_stringList_codec);
    intList_.WriteTo(output, _repeated_intList_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += stringList_.CalculateSize(_repeated_stringList_codec);
    size += intList_.CalculateSize(_repeated_intList_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(HugeResponse other) {
    if (other == null) {
      return;
    }
    stringList_.Add(other.stringList_);
    intList_.Add(other.intList_);
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
          stringList_.AddEntriesFrom(input, _repeated_stringList_codec);
          break;
        }
        case 18:
        case 16: {
          intList_.AddEntriesFrom(input, _repeated_intList_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code