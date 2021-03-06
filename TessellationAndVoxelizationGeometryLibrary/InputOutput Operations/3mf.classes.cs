// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.27210 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>3mf</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;


namespace ClassesFor_3mf_Files
{
    /// <summary>
    /// Class CT_Model.
    /// </summary>
   #if help
    internal class CT_Model
#else
    public class CT_Model
#endif
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Model"/> class.
        /// </summary>
        public CT_Model()
        {
            build = new CT_Build();
            resources = new CT_Resources();
            metadata = new List<CT_Metadata>();
            unit = ST_Unit.millimeter;
        }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        public List<CT_Metadata> metadata { get; set; }
        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        /// <value>The resources.</value>
        public CT_Resources resources { get; set; }
        /// <summary>
        /// Gets or sets the build.
        /// </summary>
        /// <value>The build.</value>
        public CT_Build build { get; set; }

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        /// <value>The unit.</value>
        [DefaultValue(ST_Unit.millimeter)]
        public ST_Unit unit { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>The language.</value>
        public string lang { get; set; }
        /// <summary>
        /// Gets or sets the requiredextensions.
        /// </summary>
        /// <value>The requiredextensions.</value>
        public string requiredextensions { get; set; }
    }

    /// <summary>
    /// Class CT_Metadata.
    /// </summary>
    #if help
    internal class CT_Metadata
#else
    public class CT_Metadata
#endif 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Metadata"/> class.
        /// </summary>
        public CT_Metadata()
        {
            Text = new List<string>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public XmlQualifiedName name { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        [XmlText]
        public List<string> Text { get; set; }
    }

    /// <summary>
    /// Class CT_Item.
    /// </summary>
     #if help
    internal class CT_Item
#else
    public class CT_Item
#endif
    {
        /// <summary>
        /// Gets or sets the objectid.
        /// </summary>
        /// <value>The objectid.</value>
        public string objectid { get; set; }
        /// <summary>
        /// Gets or sets the transform.
        /// </summary>
        /// <value>The transform.</value>
        public string transform { get; set; }
        /// <summary>
        /// Gets or sets the itemref.
        /// </summary>
        /// <value>The itemref.</value>
        public string itemref { get; set; }
    }

    /// <summary>
    /// Class CT_Build.
    /// </summary>
     #if help
    internal class CT_Build
#else
    public class CT_Build
#endif
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Build"/> class.
        /// </summary>
        public CT_Build()
        {
            item = new List<CT_Item>();
        }

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        public List<CT_Item> item { get; set; }
    }

    /// <summary>
    /// Class CT_Components.
    /// </summary>
     #if help
    internal class CT_Components
#else
    public class CT_Components
#endif 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Components"/> class.
        /// </summary>
        public CT_Components()
        {
            component = new List<CT_Component>();
        }

        /// <summary>
        /// Gets or sets the component.
        /// </summary>
        /// <value>The component.</value>
        public List<CT_Component> component { get; set; }
    }

    /// <summary>
    /// Class CT_Component.
    /// </summary>
     #if help
    internal class CT_Component
#else
    public class CT_Component
#endif  
    {
        /// <summary>
        /// Gets or sets the objectid.
        /// </summary>
        /// <value>The objectid.</value>
        public string objectid { get; set; }
        /// <summary>
        /// Gets or sets the transform.
        /// </summary>
        /// <value>The transform.</value>
        public string transform { get; set; }
    }

    /// <summary>
    /// Class CT_Triangle.
    /// </summary>
   #if help
    internal class CT_Triangle
#else
    public class CT_Triangle
#endif     
    {
        /// <summary>
        /// Gets or sets the v1.
        /// </summary>
        /// <value>The v1.</value>
        public string v1 { get; set; }
        /// <summary>
        /// Gets or sets the v2.
        /// </summary>
        /// <value>The v2.</value>
        public string v2 { get; set; }
        /// <summary>
        /// Gets or sets the v3.
        /// </summary>
        /// <value>The v3.</value>
        public string v3 { get; set; }
        /// <summary>
        /// Gets or sets the p1.
        /// </summary>
        /// <value>The p1.</value>
        public string p1 { get; set; }
        /// <summary>
        /// Gets or sets the p2.
        /// </summary>
        /// <value>The p2.</value>
        public string p2 { get; set; }
        /// <summary>
        /// Gets or sets the p3.
        /// </summary>
        /// <value>The p3.</value>
        public string p3 { get; set; }
        /// <summary>
        /// Gets or sets the pid.
        /// </summary>
        /// <value>The pid.</value>
        public string pid { get; set; }
    }

    /// <summary>
    /// Class CT_Vertex.
    /// </summary>
   #if help
    internal class CT_Vertex
#else
    public class CT_Vertex
#endif 
    {
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
        public double x { get; set; }
        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        public double y { get; set; }
        /// <summary>
        /// Gets or sets the z.
        /// </summary>
        /// <value>The z.</value>
        public double z { get; set; }
    }

    /// <summary>
    /// Class CT_Mesh.
    /// </summary>
   #if help
    internal class CT_Mesh
#else
    public class CT_Mesh
#endif  
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Mesh"/> class.
        /// </summary>
        public CT_Mesh()
        {
            triangles = new List<CT_Triangle>();
            vertices = new List<CT_Vertex>();
        }

        /// <summary>
        /// Gets or sets the vertices.
        /// </summary>
        /// <value>The vertices.</value>
        [XmlArrayItem("vertex", IsNullable = false)]
        public List<CT_Vertex> vertices { get; set; }

        /// <summary>
        /// Gets or sets the triangles.
        /// </summary>
        /// <value>The triangles.</value>
        [XmlArrayItem("triangle", IsNullable = false)]
        public List<CT_Triangle> triangles { get; set; }
    }

    /// <summary>
    /// Class CT_Object.
    /// </summary>
   #if help
    internal class CT_Object
#else
    public class CT_Object
#endif 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Object"/> class.
        /// </summary>
        public CT_Object()
        {
            type = ST_ObjectType.model;
        }

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        public object Item { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [DefaultValue(ST_ObjectType.model)]
        public ST_ObjectType type { get; set; }

        /// <summary>
        /// Gets or sets the matid.
        /// </summary>
        /// <value>The matid.</value>
        public string matid { get; set; }
        /// <summary>
        /// Gets or sets the matindex.
        /// </summary>
        /// <value>The matindex.</value>
        public string matindex { get; set; }
        /// <summary>
        /// Gets or sets the thumbnail.
        /// </summary>
        /// <value>The thumbnail.</value>
        public string thumbnail { get; set; }
        /// <summary>
        /// Gets or sets the partnumber.
        /// </summary>
        /// <value>The partnumber.</value>
        public string partnumber { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }
    }

    /// <summary>
    /// Enum ST_ObjectType
    /// </summary>
    #if help
    internal enum ST_ObjectType
#else
    public enum ST_ObjectType
#endif    
    {
        /// <summary>
        /// The model
        /// </summary>
        model,

        /// <summary>
        /// The support
        /// </summary>
        support,

        /// <summary>
        /// The other
        /// </summary>
        other
    }

    /// <summary>
    /// Class CT_Base.
    /// </summary>
   #if help
    internal class CT_Base
#else
    public class CT_Base
#endif
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }
        /// <summary>
        /// Gets or sets the displaycolor.
        /// </summary>
        /// <value>The displaycolor.</value>
        public string displaycolor { get; set; }
    }

    /// <summary>
    /// Class CT_BaseMaterials.
    /// </summary>
    #if help
    internal class CT_BaseMaterials
#else
    public class CT_BaseMaterials
#endif
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_BaseMaterials"/> class.
        /// </summary>
        public CT_BaseMaterials()
        {
            @base = new List<CT_Base>();
        }

        /// <summary>
        /// Gets or sets the base.
        /// </summary>
        /// <value>The base.</value>
        public List<CT_Base> @base { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string id { get; set; }
    }

    /// <summary>
    /// Class CT_Resources.
    /// </summary>
    #if help
    internal class CT_Resources
#else
    public class CT_Resources
#endif   
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Resources"/> class.
        /// </summary>
        public CT_Resources()
        {
            @object = new List<CT_Object>();
            basematerials = new List<CT_BaseMaterials>();
        }

        /// <summary>
        /// Gets or sets the basematerials.
        /// </summary>
        /// <value>The basematerials.</value>
        public List<CT_BaseMaterials> basematerials { get; set; }
        /// <summary>
        /// Gets or sets the object.
        /// </summary>
        /// <value>The object.</value>
        public List<CT_Object> @object { get; set; }
    }

    /// <summary>
    /// Enum ST_Unit
    /// </summary>
    #if help
    internal enum ST_Unit
#else
    public enum ST_Unit
#endif
    {
        /// <summary>
        /// The micron
        /// </summary>
        micron,

        /// <summary>
        /// The millimeter
        /// </summary>
        millimeter,

        /// <summary>
        /// The centimeter
        /// </summary>
        centimeter,

        /// <summary>
        /// The inch
        /// </summary>
        inch,

        /// <summary>
        /// The foot
        /// </summary>
        foot,

        /// <summary>
        /// The meter
        /// </summary>
        meter
    }

    /// <summary>
    /// Class CT_Vertices.
    /// </summary>
    #if help
    internal class CT_Vertices
#else
    public class CT_Vertices
#endif
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Vertices"/> class.
        /// </summary>
        public CT_Vertices()
        {
            vertex = new List<CT_Vertex>();
        }

        /// <summary>
        /// Gets or sets the vertex.
        /// </summary>
        /// <value>The vertex.</value>
        public List<CT_Vertex> vertex { get; set; }
    }

    /// <summary>
    /// Class CT_Triangles.
    /// </summary>
    #if help
    internal class CT_Triangles
#else
    public class CT_Triangles
#endif  
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CT_Triangles"/> class.
        /// </summary>
        public CT_Triangles()
        {
            triangle = new List<CT_Triangle>();
        }

        /// <summary>
        /// Gets or sets the triangle.
        /// </summary>
        /// <value>The triangle.</value>
        public List<CT_Triangle> triangle { get; set; }
    }
}