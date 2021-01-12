/*
 * Waardering onroerende zaken
 *
 * Deze API levert actuele gegevens over WOZ-objecten 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines PersoonType_enum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PersoonTypeEnum
    {
        /// <summary>
        /// Enum Natuurlijkpersoon for value: natuurlijk_persoon
        /// </summary>
        [EnumMember(Value = "natuurlijk_persoon")]
        Natuurlijkpersoon = 1,

        /// <summary>
        /// Enum Nietnatuurlijkpersoon for value: niet_natuurlijk_persoon
        /// </summary>
        [EnumMember(Value = "niet_natuurlijk_persoon")]
        Nietnatuurlijkpersoon = 2,

        /// <summary>
        /// Enum Vestiging for value: vestiging
        /// </summary>
        [EnumMember(Value = "vestiging")]
        Vestiging = 3

    }

}