// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantProfile.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/ApplicantProfile.proto</summary>
  public static partial class ApplicantProfileReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/ApplicantProfile.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplicantProfileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Qcm90b3MvQXBwbGljYW50UHJvZmlsZS5wcm90bxIQQ2FyZWVyQ2xvdWQu",
            "Z1JQQxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvIicKGUFwcGxpY2Fu",
            "dFByb2ZpbGVJZFJlcXVlc3QSCgoCSWQYASABKAkixwEKF0FwcGxpY2FudFBy",
            "b2ZpbGVQYXlsb2FkEgoKAklkGAEgASgJEg0KBUxvZ2luGAIgASgJEhUKDUN1",
            "cnJlbnRTYWxhcnkYAyABKAESEwoLQ3VycmVudFJhdGUYBCABKAESEAoIQ3Vy",
            "cmVuY3kYBSABKAkSDwoHQ291bnRyeRgGIAEoCRIQCghQcm92aW5jZRgHIAEo",
            "CRIOCgZTdHJlZXQYCCABKAkSDAoEQ2l0eRgJIAEoCRISCgpQb3N0YWxDb2Rl",
            "GAogASgJMpkDChBBcHBsaWNhbnRQcm9maWxlEm4KFFJlYWRBcHBsaWNhbnRQ",
            "cm9maWxlEisuQ2FyZWVyQ2xvdWQuZ1JQQy5BcHBsaWNhbnRQcm9maWxlSWRS",
            "ZXF1ZXN0GikuQ2FyZWVyQ2xvdWQuZ1JQQy5BcHBsaWNhbnRQcm9maWxlUGF5",
            "bG9hZBJbChZDcmVhdGVBcHBsaWNhbnRQcm9maWxlEikuQ2FyZWVyQ2xvdWQu",
            "Z1JQQy5BcHBsaWNhbnRQcm9maWxlUGF5bG9hZBoWLmdvb2dsZS5wcm90b2J1",
            "Zi5FbXB0eRJbChZVcGRhdGVBcHBsaWNhbnRQcm9maWxlEikuQ2FyZWVyQ2xv",
            "dWQuZ1JQQy5BcHBsaWNhbnRQcm9maWxlUGF5bG9hZBoWLmdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eRJbChZEZWxldGVBcHBsaWNhbnRQcm9maWxlEikuQ2FyZWVy",
            "Q2xvdWQuZ1JQQy5BcHBsaWNhbnRQcm9maWxlUGF5bG9hZBoWLmdvb2dsZS5w",
            "cm90b2J1Zi5FbXB0eUIaqgIXQ2FyZWVyQ2xvdWQuZ1JQQy5Qcm90b3NiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantProfileIdRequest), global::CareerCloud.gRPC.Protos.ApplicantProfileIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantProfilePayload), global::CareerCloud.gRPC.Protos.ApplicantProfilePayload.Parser, new[]{ "Id", "Login", "CurrentSalary", "CurrentRate", "Currency", "Country", "Province", "Street", "City", "PostalCode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ApplicantProfileIdRequest : pb::IMessage<ApplicantProfileIdRequest> {
    private static readonly pb::MessageParser<ApplicantProfileIdRequest> _parser = new pb::MessageParser<ApplicantProfileIdRequest>(() => new ApplicantProfileIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantProfileIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantProfileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfileIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfileIdRequest(ApplicantProfileIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfileIdRequest Clone() {
      return new ApplicantProfileIdRequest(this);
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
      return Equals(other as ApplicantProfileIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantProfileIdRequest other) {
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
    public void MergeFrom(ApplicantProfileIdRequest other) {
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

  public sealed partial class ApplicantProfilePayload : pb::IMessage<ApplicantProfilePayload> {
    private static readonly pb::MessageParser<ApplicantProfilePayload> _parser = new pb::MessageParser<ApplicantProfilePayload>(() => new ApplicantProfilePayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantProfilePayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantProfileReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfilePayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfilePayload(ApplicantProfilePayload other) : this() {
      id_ = other.id_;
      login_ = other.login_;
      currentSalary_ = other.currentSalary_;
      currentRate_ = other.currentRate_;
      currency_ = other.currency_;
      country_ = other.country_;
      province_ = other.province_;
      street_ = other.street_;
      city_ = other.city_;
      postalCode_ = other.postalCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfilePayload Clone() {
      return new ApplicantProfilePayload(this);
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

    /// <summary>Field number for the "Login" field.</summary>
    public const int LoginFieldNumber = 2;
    private string login_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Login {
      get { return login_; }
      set {
        login_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CurrentSalary" field.</summary>
    public const int CurrentSalaryFieldNumber = 3;
    private double currentSalary_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CurrentSalary {
      get { return currentSalary_; }
      set {
        currentSalary_ = value;
      }
    }

    /// <summary>Field number for the "CurrentRate" field.</summary>
    public const int CurrentRateFieldNumber = 4;
    private double currentRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CurrentRate {
      get { return currentRate_; }
      set {
        currentRate_ = value;
      }
    }

    /// <summary>Field number for the "Currency" field.</summary>
    public const int CurrencyFieldNumber = 5;
    private string currency_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Currency {
      get { return currency_; }
      set {
        currency_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Country" field.</summary>
    public const int CountryFieldNumber = 6;
    private string country_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Country {
      get { return country_; }
      set {
        country_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Province" field.</summary>
    public const int ProvinceFieldNumber = 7;
    private string province_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Province {
      get { return province_; }
      set {
        province_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Street" field.</summary>
    public const int StreetFieldNumber = 8;
    private string street_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Street {
      get { return street_; }
      set {
        street_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "City" field.</summary>
    public const int CityFieldNumber = 9;
    private string city_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string City {
      get { return city_; }
      set {
        city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PostalCode" field.</summary>
    public const int PostalCodeFieldNumber = 10;
    private string postalCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PostalCode {
      get { return postalCode_; }
      set {
        postalCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicantProfilePayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantProfilePayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Login != other.Login) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CurrentSalary, other.CurrentSalary)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CurrentRate, other.CurrentRate)) return false;
      if (Currency != other.Currency) return false;
      if (Country != other.Country) return false;
      if (Province != other.Province) return false;
      if (Street != other.Street) return false;
      if (City != other.City) return false;
      if (PostalCode != other.PostalCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Login.Length != 0) hash ^= Login.GetHashCode();
      if (CurrentSalary != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CurrentSalary);
      if (CurrentRate != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CurrentRate);
      if (Currency.Length != 0) hash ^= Currency.GetHashCode();
      if (Country.Length != 0) hash ^= Country.GetHashCode();
      if (Province.Length != 0) hash ^= Province.GetHashCode();
      if (Street.Length != 0) hash ^= Street.GetHashCode();
      if (City.Length != 0) hash ^= City.GetHashCode();
      if (PostalCode.Length != 0) hash ^= PostalCode.GetHashCode();
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
      if (Login.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Login);
      }
      if (CurrentSalary != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(CurrentSalary);
      }
      if (CurrentRate != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(CurrentRate);
      }
      if (Currency.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Currency);
      }
      if (Country.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Country);
      }
      if (Province.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Province);
      }
      if (Street.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Street);
      }
      if (City.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(City);
      }
      if (PostalCode.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(PostalCode);
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
      if (Login.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Login);
      }
      if (CurrentSalary != 0D) {
        size += 1 + 8;
      }
      if (CurrentRate != 0D) {
        size += 1 + 8;
      }
      if (Currency.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Currency);
      }
      if (Country.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Country);
      }
      if (Province.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Province);
      }
      if (Street.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Street);
      }
      if (City.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
      }
      if (PostalCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostalCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicantProfilePayload other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Login.Length != 0) {
        Login = other.Login;
      }
      if (other.CurrentSalary != 0D) {
        CurrentSalary = other.CurrentSalary;
      }
      if (other.CurrentRate != 0D) {
        CurrentRate = other.CurrentRate;
      }
      if (other.Currency.Length != 0) {
        Currency = other.Currency;
      }
      if (other.Country.Length != 0) {
        Country = other.Country;
      }
      if (other.Province.Length != 0) {
        Province = other.Province;
      }
      if (other.Street.Length != 0) {
        Street = other.Street;
      }
      if (other.City.Length != 0) {
        City = other.City;
      }
      if (other.PostalCode.Length != 0) {
        PostalCode = other.PostalCode;
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
            Login = input.ReadString();
            break;
          }
          case 25: {
            CurrentSalary = input.ReadDouble();
            break;
          }
          case 33: {
            CurrentRate = input.ReadDouble();
            break;
          }
          case 42: {
            Currency = input.ReadString();
            break;
          }
          case 50: {
            Country = input.ReadString();
            break;
          }
          case 58: {
            Province = input.ReadString();
            break;
          }
          case 66: {
            Street = input.ReadString();
            break;
          }
          case 74: {
            City = input.ReadString();
            break;
          }
          case 82: {
            PostalCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
