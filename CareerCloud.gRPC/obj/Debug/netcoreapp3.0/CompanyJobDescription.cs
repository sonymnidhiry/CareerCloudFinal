// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJobDescription.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyJobDescription.proto</summary>
  public static partial class CompanyJobDescriptionReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyJobDescription.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyJobDescriptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQcm90b3MvQ29tcGFueUpvYkRlc2NyaXB0aW9uLnByb3RvEhBDYXJlZXJD",
            "bG91ZC5nUlBDGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8iLAoeQ29t",
            "cGFueUpvYkRlc2NyaXB0aW9uSWRSZXF1ZXN0EgoKAklkGAEgASgJImEKHENv",
            "bXBhbnlKb2JEZXNjcmlwdGlvblBheWxvYWQSCgoCSWQYASABKAkSCwoDSm9i",
            "GAIgASgJEg8KB0pvYk5hbWUYAyABKAkSFwoPSm9iRGVzY3JpcHRpb25zGAQg",
            "ASgJMssDChVDb21wYW55Sm9iRGVzY3JpcHRpb24SfQoZUmVhZENvbXBhbnlK",
            "b2JEZXNjcmlwdGlvbhIwLkNhcmVlckNsb3VkLmdSUEMuQ29tcGFueUpvYkRl",
            "c2NyaXB0aW9uSWRSZXF1ZXN0Gi4uQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55",
            "Sm9iRGVzY3JpcHRpb25QYXlsb2FkEmUKG0NyZWF0ZUNvbXBhbnlKb2JEZXNj",
            "cmlwdGlvbhIuLkNhcmVlckNsb3VkLmdSUEMuQ29tcGFueUpvYkRlc2NyaXB0",
            "aW9uUGF5bG9hZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJlChtVcGRhdGVD",
            "b21wYW55Sm9iRGVzY3JpcHRpb24SLi5DYXJlZXJDbG91ZC5nUlBDLkNvbXBh",
            "bnlKb2JEZXNjcmlwdGlvblBheWxvYWQaFi5nb29nbGUucHJvdG9idWYuRW1w",
            "dHkSZQobRGVsZXRlQ29tcGFueUpvYkRlc2NyaXB0aW9uEi4uQ2FyZWVyQ2xv",
            "dWQuZ1JQQy5Db21wYW55Sm9iRGVzY3JpcHRpb25QYXlsb2FkGhYuZ29vZ2xl",
            "LnByb3RvYnVmLkVtcHR5QhqqAhdDYXJlZXJDbG91ZC5nUlBDLlByb3Rvc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobDescriptionIdRequest), global::CareerCloud.gRPC.Protos.CompanyJobDescriptionIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobDescriptionPayload), global::CareerCloud.gRPC.Protos.CompanyJobDescriptionPayload.Parser, new[]{ "Id", "Job", "JobName", "JobDescriptions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompanyJobDescriptionIdRequest : pb::IMessage<CompanyJobDescriptionIdRequest> {
    private static readonly pb::MessageParser<CompanyJobDescriptionIdRequest> _parser = new pb::MessageParser<CompanyJobDescriptionIdRequest>(() => new CompanyJobDescriptionIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobDescriptionIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobDescriptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionIdRequest(CompanyJobDescriptionIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionIdRequest Clone() {
      return new CompanyJobDescriptionIdRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobDescriptionIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobDescriptionIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobDescriptionIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyJobDescriptionPayload : pb::IMessage<CompanyJobDescriptionPayload> {
    private static readonly pb::MessageParser<CompanyJobDescriptionPayload> _parser = new pb::MessageParser<CompanyJobDescriptionPayload>(() => new CompanyJobDescriptionPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobDescriptionPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobDescriptionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionPayload(CompanyJobDescriptionPayload other) : this() {
      id_ = other.id_;
      job_ = other.job_;
      jobName_ = other.jobName_;
      jobDescriptions_ = other.jobDescriptions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionPayload Clone() {
      return new CompanyJobDescriptionPayload(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Job" field.</summary>
    public const int JobFieldNumber = 2;
    private string job_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Job {
      get { return job_; }
      set {
        job_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JobName" field.</summary>
    public const int JobNameFieldNumber = 3;
    private string jobName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobName {
      get { return jobName_; }
      set {
        jobName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JobDescriptions" field.</summary>
    public const int JobDescriptionsFieldNumber = 4;
    private string jobDescriptions_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobDescriptions {
      get { return jobDescriptions_; }
      set {
        jobDescriptions_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobDescriptionPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobDescriptionPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Job != other.Job) return false;
      if (JobName != other.JobName) return false;
      if (JobDescriptions != other.JobDescriptions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Job.Length != 0) hash ^= Job.GetHashCode();
      if (JobName.Length != 0) hash ^= JobName.GetHashCode();
      if (JobDescriptions.Length != 0) hash ^= JobDescriptions.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Job.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Job);
      }
      if (JobName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(JobName);
      }
      if (JobDescriptions.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(JobDescriptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Job.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Job);
      }
      if (JobName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobName);
      }
      if (JobDescriptions.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobDescriptions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobDescriptionPayload other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Job.Length != 0) {
        Job = other.Job;
      }
      if (other.JobName.Length != 0) {
        JobName = other.JobName;
      }
      if (other.JobDescriptions.Length != 0) {
        JobDescriptions = other.JobDescriptions;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Job = input.ReadString();
            break;
          }
          case 26: {
            JobName = input.ReadString();
            break;
          }
          case 34: {
            JobDescriptions = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
