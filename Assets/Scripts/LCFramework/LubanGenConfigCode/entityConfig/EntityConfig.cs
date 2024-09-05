//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.entityConfig
{ 

public sealed partial class EntityConfig :  Bright.Config.BeanBase 
{
    public EntityConfig(JSONNode _json) 
    {
        { if(!_json["Id"].IsNumber) { throw new SerializationException(); }  Id = _json["Id"]; }
        { if(!_json["PrefabId"].IsNumber) { throw new SerializationException(); }  PrefabId = _json["PrefabId"]; }
        { var __json0 = _json["ComponentTypes"]; if(!__json0.IsArray) { throw new SerializationException(); } ComponentTypes = new System.Collections.Generic.List<ComponentType>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ComponentType __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = (ComponentType)__e0.AsInt; }  ComponentTypes.Add(__v0); }   }
        { if(!_json["Desc"].IsString) { throw new SerializationException(); }  Desc = _json["Desc"]; }
        PostInit();
    }

    public EntityConfig(long Id, long PrefabId, System.Collections.Generic.List<ComponentType> ComponentTypes, string Desc ) 
    {
        this.Id = Id;
        this.PrefabId = PrefabId;
        this.ComponentTypes = ComponentTypes;
        this.Desc = Desc;
        PostInit();
    }

    public static EntityConfig DeserializeEntityConfig(JSONNode _json)
    {
        return new entityConfig.EntityConfig(_json);
    }

    /// <summary>
    /// 实体Id
    /// </summary>
    public long Id { get; private set; }
    /// <summary>
    /// 模型Id
    /// </summary>
    public long PrefabId { get; private set; }
    /// <summary>
    /// 实体组件
    /// </summary>
    public System.Collections.Generic.List<ComponentType> ComponentTypes { get; private set; }
    /// <summary>
    /// 备注
    /// </summary>
    public string Desc { get; private set; }

    public const int __ID__ = -1265463442;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "PrefabId:" + PrefabId + ","
        + "ComponentTypes:" + Bright.Common.StringUtil.CollectionToString(ComponentTypes) + ","
        + "Desc:" + Desc + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
