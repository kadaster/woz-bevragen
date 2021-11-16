/*
 * Waardering onroerende zaken
 *
 * Deze API levert actuele gegevens over WOZ-objecten 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Belanghebbende
    /// </summary>
    [DataContract]
    public partial class Belanghebbende :  IEquatable<Belanghebbende>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public PersoonTypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Belanghebbende" /> class.
        /// </summary>
        /// <param name="burgerservicenummer">burgerservicenummer.</param>
        /// <param name="geheimhoudingPersoonsgegevens">Indien true: op verzoek van deze persoon is het verstrekken van gegevens over deze persoon aan bepaalde derden niet toegestaan..</param>
        /// <param name="kvkNummer">kvkNummer.</param>
        /// <param name="naam">naam.</param>
        /// <param name="rsin">unieke identificatie van een niet-natuurlijk persoon (rechtspersoon of samenwerkingsverband).</param>
        /// <param name="type">type.</param>
        /// <param name="vestigingsnummer">vestigingsnummer.</param>
        public Belanghebbende(string burgerservicenummer = default(string), bool geheimhoudingPersoonsgegevens = default(bool), string kvkNummer = default(string), string naam = default(string), string rsin = default(string), PersoonTypeEnum? type = default(PersoonTypeEnum?), string vestigingsnummer = default(string))
        {
            this.Burgerservicenummer = burgerservicenummer;
            this.GeheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
            this.KvkNummer = kvkNummer;
            this.Naam = naam;
            this.Rsin = rsin;
            this.Type = type;
            this.Vestigingsnummer = vestigingsnummer;
        }

        /// <summary>
        /// Gets or Sets Burgerservicenummer
        /// </summary>
        [DataMember(Name="burgerservicenummer", EmitDefaultValue=false)]
        public string Burgerservicenummer { get; set; }

        /// <summary>
        /// Indien true: op verzoek van deze persoon is het verstrekken van gegevens over deze persoon aan bepaalde derden niet toegestaan.
        /// </summary>
        /// <value>Indien true: op verzoek van deze persoon is het verstrekken van gegevens over deze persoon aan bepaalde derden niet toegestaan.</value>
        [DataMember(Name="geheimhoudingPersoonsgegevens", EmitDefaultValue=false)]
        public bool GeheimhoudingPersoonsgegevens { get; set; }

        /// <summary>
        /// Gets or Sets KvkNummer
        /// </summary>
        [DataMember(Name="kvkNummer", EmitDefaultValue=false)]
        public string KvkNummer { get; set; }

        /// <summary>
        /// Gets or Sets Naam
        /// </summary>
        [DataMember(Name="naam", EmitDefaultValue=false)]
        public string Naam { get; set; }

        /// <summary>
        /// unieke identificatie van een niet-natuurlijk persoon (rechtspersoon of samenwerkingsverband)
        /// </summary>
        /// <value>unieke identificatie van een niet-natuurlijk persoon (rechtspersoon of samenwerkingsverband)</value>
        [DataMember(Name="rsin", EmitDefaultValue=false)]
        public string Rsin { get; set; }


        /// <summary>
        /// Gets or Sets Vestigingsnummer
        /// </summary>
        [DataMember(Name="vestigingsnummer", EmitDefaultValue=false)]
        public string Vestigingsnummer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Belanghebbende {\n");
            sb.Append("  Burgerservicenummer: ").Append(Burgerservicenummer).Append("\n");
            sb.Append("  GeheimhoudingPersoonsgegevens: ").Append(GeheimhoudingPersoonsgegevens).Append("\n");
            sb.Append("  KvkNummer: ").Append(KvkNummer).Append("\n");
            sb.Append("  Naam: ").Append(Naam).Append("\n");
            sb.Append("  Rsin: ").Append(Rsin).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Vestigingsnummer: ").Append(Vestigingsnummer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Belanghebbende);
        }

        /// <summary>
        /// Returns true if Belanghebbende instances are equal
        /// </summary>
        /// <param name="input">Instance of Belanghebbende to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Belanghebbende input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Burgerservicenummer == input.Burgerservicenummer ||
                    (this.Burgerservicenummer != null &&
                    this.Burgerservicenummer.Equals(input.Burgerservicenummer))
                ) && 
                (
                    this.GeheimhoudingPersoonsgegevens == input.GeheimhoudingPersoonsgegevens ||
                    (this.GeheimhoudingPersoonsgegevens != null &&
                    this.GeheimhoudingPersoonsgegevens.Equals(input.GeheimhoudingPersoonsgegevens))
                ) && 
                (
                    this.KvkNummer == input.KvkNummer ||
                    (this.KvkNummer != null &&
                    this.KvkNummer.Equals(input.KvkNummer))
                ) && 
                (
                    this.Naam == input.Naam ||
                    (this.Naam != null &&
                    this.Naam.Equals(input.Naam))
                ) && 
                (
                    this.Rsin == input.Rsin ||
                    (this.Rsin != null &&
                    this.Rsin.Equals(input.Rsin))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Vestigingsnummer == input.Vestigingsnummer ||
                    (this.Vestigingsnummer != null &&
                    this.Vestigingsnummer.Equals(input.Vestigingsnummer))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Burgerservicenummer != null)
                    hashCode = hashCode * 59 + this.Burgerservicenummer.GetHashCode();
                if (this.GeheimhoudingPersoonsgegevens != null)
                    hashCode = hashCode * 59 + this.GeheimhoudingPersoonsgegevens.GetHashCode();
                if (this.KvkNummer != null)
                    hashCode = hashCode * 59 + this.KvkNummer.GetHashCode();
                if (this.Naam != null)
                    hashCode = hashCode * 59 + this.Naam.GetHashCode();
                if (this.Rsin != null)
                    hashCode = hashCode * 59 + this.Rsin.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Vestigingsnummer != null)
                    hashCode = hashCode * 59 + this.Vestigingsnummer.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
