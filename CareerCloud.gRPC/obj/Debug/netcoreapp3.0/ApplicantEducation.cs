// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantEducation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/ApplicantEducation.proto</summary>
  public static partial class ApplicantEducationReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/ApplicantEducation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplicantEducationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Qcm90b3MvQXBwbGljYW50RWR1Y2F0aW9uLnByb3RvEhBDYXJlZXJDbG91",
            "ZC5nUlBDGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aH2dvb2dsZS9w",
            "cm90b2J1Zi90aW1lc3RhbXAucHJvdG8iFwoJSWRSZXF1ZXN0EgoKAklkGAEg",
            "ASgJIuUBChlBcHBsaWNhbnRFZHVjYXRpb25QYXlsb2FkEgoKAklkGAEgASgJ",
            "EhEKCUFwcGxpY2FudBgCIAEoCRINCgVNYWpvchgDIAEoCRIcChRDZXJ0aWZp",
            "Y2F0aW9uRGlwbG9tYRgEIAEoCRItCglTdGFydERhdGUYBSABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuVGltZXN0YW1wEjIKDkNvbXBsZXRpb25EYXRlGAYgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIZChFDb21wbGV0aW9uUGVy",
            "Y2VudBgHIAEoBTKbAwoSQXBwbGljYW50RWR1Y2F0aW9uEmIKFlJlYWRBcHBs",
            "aWNhbnRFZHVjYXRpb24SGy5DYXJlZXJDbG91ZC5nUlBDLklkUmVxdWVzdBor",
            "LkNhcmVlckNsb3VkLmdSUEMuQXBwbGljYW50RWR1Y2F0aW9uUGF5bG9hZBJf",
            "ChhDcmVhdGVBcHBsaWNhbnRFZHVjYXRpb24SKy5DYXJlZXJDbG91ZC5nUlBD",
            "LkFwcGxpY2FudEVkdWNhdGlvblBheWxvYWQaFi5nb29nbGUucHJvdG9idWYu",
            "RW1wdHkSXwoYVXBkYXRlQXBwbGljYW50RWR1Y2F0aW9uEisuQ2FyZWVyQ2xv",
            "dWQuZ1JQQy5BcHBsaWNhbnRFZHVjYXRpb25QYXlsb2FkGhYuZ29vZ2xlLnBy",
            "b3RvYnVmLkVtcHR5El8KGERlbGV0ZUFwcGxpY2FudEVkdWNhdGlvbhIrLkNh",
            "cmVlckNsb3VkLmdSUEMuQXBwbGljYW50RWR1Y2F0aW9uUGF5bG9hZBoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eUIaqgIXQ2FyZWVyQ2xvdWQuZ1JQQy5Qcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.IdRequest), global::CareerCloud.gRPC.Protos.IdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantEducationPayload), global::CareerCloud.gRPC.Protos.ApplicantEducationPayload.Parser, new[]{ "Id", "Applicant", "Major", "CertificationDiploma", "StartDate", "CompletionDate", "CompletionPercent" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IdRequest : pb::IMessage<IdRequest> {
    private static readonly pb::MessageParser<IdRequest> _parser = new pb::MessageParser<IdRequest>(() => new IdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantEducationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest(IdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest Clone() {
      return new IdRequest(this);
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
      return Equals(other as IdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdRequest other) {
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
    public void MergeFrom(IdRequest other) {
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

  public sealed partial class ApplicantEducationPayload : pb::IMessage<ApplicantEducationPayload> {
    private static readonly pb::MessageParser<ApplicantEducationPayload> _parser = new pb::MessageParser<ApplicantEducationPayload>(() => new ApplicantEducationPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantEducationPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantEducationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantEducationPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantEducationPayload(ApplicantEducationPayload other) : this() {
      id_ = other.id_;
      applicant_ = other.applicant_;
      major_ = other.major_;
      certificationDiploma_ = other.certificationDiploma_;
      startDate_ = other.startDate_ != null ? other.startDate_.Clone() : null;
      completionDate_ = other.completionDate_ != null ? other.completionDate_.Clone() : null;
      completionPercent_ = other.completionPercent_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantEducationPayload Clone() {
      return new ApplicantEducationPayload(this);
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

    /// <summary>Field number for the "Applicant" field.</summary>
    public const int ApplicantFieldNumber = 2;
    private string applicant_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Applicant {
      get { return applicant_; }
      set {
        applicant_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Major" field.</summary>
    public const int MajorFieldNumber = 3;
    private string major_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Major {
      get { return major_; }
      set {
        major_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CertificationDiploma" field.</summary>
    public const int CertificationDiplomaFieldNumber = 4;
    private string certificationDiploma_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CertificationDiploma {
      get { return certificationDiploma_; }
      set {
        certificationDiploma_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "StartDate" field.</summary>
    public const int StartDateFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartDate {
      get { return startDate_; }
      set {
        startDate_ = value;
      }
    }

    /// <summary>Field number for the "CompletionDate" field.</summary>
    public const int CompletionDateFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp completionDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CompletionDate {
      get { return completionDate_; }
      set {
        completionDate_ = value;
      }
    }

    /// <summary>Field number for the "CompletionPercent" field.</summary>
    public const int CompletionPercentFieldNumber = 7;
    private int completionPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CompletionPercent {
      get { return completionPercent_; }
      set {
        completionPercent_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicantEducationPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantEducationPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Applicant != other.Applicant) return false;
      if (Major != other.Major) return false;
      if (CertificationDiploma != other.CertificationDiploma) return false;
      if (!object.Equals(StartDate, other.StartDate)) return false;
      if (!object.Equals(CompletionDate, other.CompletionDate)) return false;
      if (CompletionPercent != other.CompletionPercent) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Applicant.Length != 0) hash ^= Applicant.GetHashCode();
      if (Major.Length != 0) hash ^= Major.GetHashCode();
      if (CertificationDiploma.Length != 0) hash ^= CertificationDiploma.GetHashCode();
      if (startDate_ != null) hash ^= StartDate.GetHashCode();
      if (completionDate_ != null) hash ^= CompletionDate.GetHashCode();
      if (CompletionPercent != 0) hash ^= CompletionPercent.GetHashCode();
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
      if (Applicant.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Applicant);
      }
      if (Major.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Major);
      }
      if (CertificationDiploma.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CertificationDiploma);
      }
      if (startDate_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(StartDate);
      }
      if (completionDate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CompletionDate);
      }
      if (CompletionPercent != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(CompletionPercent);
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
      if (Applicant.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Applicant);
      }
      if (Major.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Major);
      }
      if (CertificationDiploma.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CertificationDiploma);
      }
      if (startDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartDate);
      }
      if (completionDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CompletionDate);
      }
      if (CompletionPercent != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CompletionPercent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicantEducationPayload other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Applicant.Length != 0) {
        Applicant = other.Applicant;
      }
      if (other.Major.Length != 0) {
        Major = other.Major;
      }
      if (other.CertificationDiploma.Length != 0) {
        CertificationDiploma = other.CertificationDiploma;
      }
      if (other.startDate_ != null) {
        if (startDate_ == null) {
          StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartDate.MergeFrom(other.StartDate);
      }
      if (other.completionDate_ != null) {
        if (completionDate_ == null) {
          CompletionDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CompletionDate.MergeFrom(other.CompletionDate);
      }
      if (other.CompletionPercent != 0) {
        CompletionPercent = other.CompletionPercent;
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
            Applicant = input.ReadString();
            break;
          }
          case 26: {
            Major = input.ReadString();
            break;
          }
          case 34: {
            CertificationDiploma = input.ReadString();
            break;
          }
          case 42: {
            if (startDate_ == null) {
              StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartDate);
            break;
          }
          case 50: {
            if (completionDate_ == null) {
              CompletionDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CompletionDate);
            break;
          }
          case 56: {
            CompletionPercent = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code