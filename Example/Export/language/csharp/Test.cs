// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Test.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HiProtobuf {

  /// <summary>Holder for reflection information generated from Test.proto</summary>
  public static partial class TestReflection {

    #region Descriptor
    /// <summary>File descriptor for Test.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpUZXN0LnByb3RvEgpIaVByb3RvYnVmIksKBFRlc3QSCgoCaWQYASABKAUS",
            "DAoEbmFtZRgCIAEoCRIKCgJocBgDIAEoBRIOCgZhdHRhY2sYBCABKAUSDQoF",
            "aW5mb3MYBSADKAkiewoKRXhjZWxfVGVzdBIuCgREYXRhGAEgAygLMiAuSGlQ",
            "cm90b2J1Zi5FeGNlbF9UZXN0LkRhdGFFbnRyeRo9CglEYXRhRW50cnkSCwoD",
            "a2V5GAEgASgFEh8KBXZhbHVlGAIgASgLMhAuSGlQcm90b2J1Zi5UZXN0OgI4",
            "AUI4Chljb20uSGlQcm90b2J1Zi5IaVByb3RvYnVmQg5UZXN0X2NsYXNzbmFt",
            "ZaoCCkhpUHJvdG9idWZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HiProtobuf.Test), global::HiProtobuf.Test.Parser, new[]{ "Id", "Name", "Hp", "Attack", "Infos" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HiProtobuf.Excel_Test), global::HiProtobuf.Excel_Test.Parser, new[]{ "Data" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Test : pb::IMessage<Test> {
    private static readonly pb::MessageParser<Test> _parser = new pb::MessageParser<Test>(() => new Test());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Test> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HiProtobuf.TestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Test() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Test(Test other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      hp_ = other.hp_;
      attack_ = other.attack_;
      infos_ = other.infos_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Test Clone() {
      return new Test(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 3;
    private int hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "attack" field.</summary>
    public const int AttackFieldNumber = 4;
    private int attack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Attack {
      get { return attack_; }
      set {
        attack_ = value;
      }
    }

    /// <summary>Field number for the "infos" field.</summary>
    public const int InfosFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_infos_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> infos_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Infos {
      get { return infos_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Test);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Test other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Hp != other.Hp) return false;
      if (Attack != other.Attack) return false;
      if(!infos_.Equals(other.infos_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (Attack != 0) hash ^= Attack.GetHashCode();
      hash ^= infos_.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Hp != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Hp);
      }
      if (Attack != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Attack);
      }
      infos_.WriteTo(output, _repeated_infos_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hp);
      }
      if (Attack != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Attack);
      }
      size += infos_.CalculateSize(_repeated_infos_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Test other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.Attack != 0) {
        Attack = other.Attack;
      }
      infos_.Add(other.infos_);
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
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Hp = input.ReadInt32();
            break;
          }
          case 32: {
            Attack = input.ReadInt32();
            break;
          }
          case 42: {
            infos_.AddEntriesFrom(input, _repeated_infos_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Excel_Test : pb::IMessage<Excel_Test> {
    private static readonly pb::MessageParser<Excel_Test> _parser = new pb::MessageParser<Excel_Test>(() => new Excel_Test());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Excel_Test> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HiProtobuf.TestReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Excel_Test() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Excel_Test(Excel_Test other) : this() {
      data_ = other.data_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Excel_Test Clone() {
      return new Excel_Test(this);
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pbc::MapField<int, global::HiProtobuf.Test>.Codec _map_data_codec
        = new pbc::MapField<int, global::HiProtobuf.Test>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::HiProtobuf.Test.Parser), 10);
    private readonly pbc::MapField<int, global::HiProtobuf.Test> data_ = new pbc::MapField<int, global::HiProtobuf.Test>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::HiProtobuf.Test> Data {
      get { return data_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Excel_Test);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Excel_Test other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Data.Equals(other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Data.GetHashCode();
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
      data_.WriteTo(output, _map_data_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += data_.CalculateSize(_map_data_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Excel_Test other) {
      if (other == null) {
        return;
      }
      data_.Add(other.data_);
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
            data_.AddEntriesFrom(input, _map_data_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
