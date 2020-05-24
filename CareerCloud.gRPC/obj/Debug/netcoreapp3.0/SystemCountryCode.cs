// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SystemCountryCode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/SystemCountryCode.proto</summary>
  public static partial class SystemCountryCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/SystemCountryCode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SystemCountryCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Qcm90b3MvU3lzdGVtQ291bnRyeUNvZGUucHJvdG8SEENhcmVlckNsb3Vk",
            "LmdSUEMaG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90byIqChpTeXN0ZW1D",
            "b3VudHJ5Q29kZUlkUmVxdWVzdBIMCgRDb2RlGAEgASgJIjYKGFN5c3RlbUNv",
            "dW50cnlDb2RlUGF5bG9hZBIMCgRDb2RlGAEgASgJEgwKBE5hbWUYAiABKAky",
            "owMKEVN5c3RlbUNvdW50cnlDb2RlEnEKFVJlYWRTeXN0ZW1Db3VudHJ5Q29k",
            "ZRIsLkNhcmVlckNsb3VkLmdSUEMuU3lzdGVtQ291bnRyeUNvZGVJZFJlcXVl",
            "c3QaKi5DYXJlZXJDbG91ZC5nUlBDLlN5c3RlbUNvdW50cnlDb2RlUGF5bG9h",
            "ZBJdChdDcmVhdGVTeXN0ZW1Db3VudHJ5Q29kZRIqLkNhcmVlckNsb3VkLmdS",
            "UEMuU3lzdGVtQ291bnRyeUNvZGVQYXlsb2FkGhYuZ29vZ2xlLnByb3RvYnVm",
            "LkVtcHR5El0KF1VwZGF0ZVN5c3RlbUNvdW50cnlDb2RlEiouQ2FyZWVyQ2xv",
            "dWQuZ1JQQy5TeXN0ZW1Db3VudHJ5Q29kZVBheWxvYWQaFi5nb29nbGUucHJv",
            "dG9idWYuRW1wdHkSXQoXRGVsZXRlU3lzdGVtQ291bnRyeUNvZGUSKi5DYXJl",
            "ZXJDbG91ZC5nUlBDLlN5c3RlbUNvdW50cnlDb2RlUGF5bG9hZBoWLmdvb2ds",
            "ZS5wcm90b2J1Zi5FbXB0eUIaqgIXQ2FyZWVyQ2xvdWQuZ1JQQy5Qcm90b3Ni",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SystemCountryCodeIdRequest), global::CareerCloud.gRPC.Protos.SystemCountryCodeIdRequest.Parser, new[]{ "Code" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SystemCountryCodePayload), global::CareerCloud.gRPC.Protos.SystemCountryCodePayload.Parser, new[]{ "Code", "Name" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SystemCountryCodeIdRequest : pb::IMessage<SystemCountryCodeIdRequest> {
    private static readonly pb::MessageParser<SystemCountryCodeIdRequest> _parser = new pb::MessageParser<SystemCountryCodeIdRequest>(() => new SystemCountryCodeIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemCountryCodeIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SystemCountryCodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemCountryCodeIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemCountryCodeIdRequest(SystemCountryCodeIdRequest other) : this() {
      code_ = other.code_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemCountryCodeIdRequest Clone() {
      return new SystemCountryCodeIdRequest(this);
    }

    /// <summary>Field number for the "Code" field.</summary>
    public const int CodeFieldNumber = 1;
    private string code_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Code {
      get { return code_; }
      set {
        code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemCountryCodeIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemCountryCodeIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code.Length != 0) hash ^= Code.GetHashCode();
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
      if (Code.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Code);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemCountryCodeIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.Code.Length != 0) {
        Code = other.Code;
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
            Code = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SystemCountryCodePayload : pb::IMessage<SystemCountryCodePayload> {
    private static readonly pb::MessageParser<SystemCountryCodePayload> _parser = new pb::MessageParser<SystemCountryCodePayload>(() => new SystemCountryCodePayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemCountryCodePayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SystemCountryCodeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemCountryCodePayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemCountryCodePayload(SystemCountryCodePayload other) : this() {
      code_ = other.code_;
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemCountryCodePayload Clone() {
      return new SystemCountryCodePayload(this);
    }

    /// <summary>Field number for the "Code" field.</summary>
    public const int CodeFieldNumber = 1;
    private string code_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Code {
      get { return code_; }
      set {
        code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemCountryCodePayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemCountryCodePayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code.Length != 0) hash ^= Code.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Code.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Code);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemCountryCodePayload other) {
      if (other == null) {
        return;
      }
      if (other.Code.Length != 0) {
        Code = other.Code;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
            Code = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
