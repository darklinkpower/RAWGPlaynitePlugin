/* 
 * RAWG Video Games Database API
 *
 *  The largest open video games database.  ### Why build on RAWG - More than 350,000 games for 50 platforms including mobiles. - Rich metadata: tags, genres, developers, publishers, individual creators, official websites, release dates, Metacritic ratings. - Where to buy: links to digital distribution services - Similar games based on visual similarity. - Player activity data: Steam average playtime and RAWG player counts and ratings. - Actively developing and constantly getting better by user contribution and our algorithms.  ### Terms of Use - Free for personal use as long as you attribute RAWG as the source of the data and/or images and add an active hyperlink from every page where the data of RAWG is used. - Free for commercial use for startups and hobby projects with not more than 100,000 monthly active users or 500,000 page views per month. If your project is larger than that, email us at [api@rawg.io](mailto:api@rawg.io) for commercial terms. - No cloning. It would not be cool if you used our API to launch a clone of RAWG. We know it is not always easy to say what is a duplicate and what isn't. Drop us a line at [api@rawg.io](mailto:api@rawg.io) if you are in doubt, and we will talk it through. - Every API request should have a User-Agent header with your app name. If you don’t provide it, we may ban your requests.  __[Read more](https://rawg.io/apidocs)__. 
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Game
    /// </summary>
    [DataContract]
    public partial class Game :  IEquatable<Game>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Game" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Game() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Game" /> class.
        /// </summary>
        /// <param name="rating">rating (required).</param>
        public Game(decimal? rating = default(decimal?))
        {
            // to ensure "rating" is required (not null)
            if (rating == null)
            {
                throw new InvalidDataException("rating is a required property for Game and cannot be null");
            }
            else
            {
                this.Rating = rating;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets Released
        /// </summary>
        [DataMember(Name="released", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Released { get; private set; }

        /// <summary>
        /// Gets or Sets Tba
        /// </summary>
        [DataMember(Name="tba", EmitDefaultValue=false)]
        public bool? Tba { get; private set; }

        /// <summary>
        /// Gets or Sets BackgroundImage
        /// </summary>
        [DataMember(Name="background_image", EmitDefaultValue=false)]
        public string BackgroundImage { get; private set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Gets or Sets RatingTop
        /// </summary>
        [DataMember(Name="rating_top", EmitDefaultValue=false)]
        public int? RatingTop { get; private set; }

        /// <summary>
        /// Gets or Sets Ratings
        /// </summary>
        [DataMember(Name="ratings", EmitDefaultValue=false)]
        public Object Ratings { get; private set; }

        /// <summary>
        /// Gets or Sets RatingsCount
        /// </summary>
        [DataMember(Name="ratings_count", EmitDefaultValue=false)]
        public int? RatingsCount { get; private set; }

        /// <summary>
        /// Gets or Sets ReviewsTextCount
        /// </summary>
        [DataMember(Name="reviews_text_count", EmitDefaultValue=false)]
        public string ReviewsTextCount { get; private set; }

        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public int? Added { get; private set; }

        /// <summary>
        /// Gets or Sets AddedByStatus
        /// </summary>
        [DataMember(Name="added_by_status", EmitDefaultValue=false)]
        public Object AddedByStatus { get; private set; }

        /// <summary>
        /// Gets or Sets Metacritic
        /// </summary>
        [DataMember(Name="metacritic", EmitDefaultValue=false)]
        public int? Metacritic { get; private set; }

        /// <summary>
        /// in hours
        /// </summary>
        /// <value>in hours</value>
        [DataMember(Name="playtime", EmitDefaultValue=false)]
        public int? Playtime { get; private set; }

        /// <summary>
        /// Gets or Sets SuggestionsCount
        /// </summary>
        [DataMember(Name="suggestions_count", EmitDefaultValue=false)]
        public int? SuggestionsCount { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Game {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Released: ").Append(Released).Append("\n");
            sb.Append("  Tba: ").Append(Tba).Append("\n");
            sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  RatingTop: ").Append(RatingTop).Append("\n");
            sb.Append("  Ratings: ").Append(Ratings).Append("\n");
            sb.Append("  RatingsCount: ").Append(RatingsCount).Append("\n");
            sb.Append("  ReviewsTextCount: ").Append(ReviewsTextCount).Append("\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  AddedByStatus: ").Append(AddedByStatus).Append("\n");
            sb.Append("  Metacritic: ").Append(Metacritic).Append("\n");
            sb.Append("  Playtime: ").Append(Playtime).Append("\n");
            sb.Append("  SuggestionsCount: ").Append(SuggestionsCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Game);
        }

        /// <summary>
        /// Returns true if Game instances are equal
        /// </summary>
        /// <param name="input">Instance of Game to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Game input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Released == input.Released ||
                    (this.Released != null &&
                    this.Released.Equals(input.Released))
                ) && 
                (
                    this.Tba == input.Tba ||
                    (this.Tba != null &&
                    this.Tba.Equals(input.Tba))
                ) && 
                (
                    this.BackgroundImage == input.BackgroundImage ||
                    (this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(input.BackgroundImage))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.RatingTop == input.RatingTop ||
                    (this.RatingTop != null &&
                    this.RatingTop.Equals(input.RatingTop))
                ) && 
                (
                    this.Ratings == input.Ratings ||
                    (this.Ratings != null &&
                    this.Ratings.Equals(input.Ratings))
                ) && 
                (
                    this.RatingsCount == input.RatingsCount ||
                    (this.RatingsCount != null &&
                    this.RatingsCount.Equals(input.RatingsCount))
                ) && 
                (
                    this.ReviewsTextCount == input.ReviewsTextCount ||
                    (this.ReviewsTextCount != null &&
                    this.ReviewsTextCount.Equals(input.ReviewsTextCount))
                ) && 
                (
                    this.Added == input.Added ||
                    (this.Added != null &&
                    this.Added.Equals(input.Added))
                ) && 
                (
                    this.AddedByStatus == input.AddedByStatus ||
                    (this.AddedByStatus != null &&
                    this.AddedByStatus.Equals(input.AddedByStatus))
                ) && 
                (
                    this.Metacritic == input.Metacritic ||
                    (this.Metacritic != null &&
                    this.Metacritic.Equals(input.Metacritic))
                ) && 
                (
                    this.Playtime == input.Playtime ||
                    (this.Playtime != null &&
                    this.Playtime.Equals(input.Playtime))
                ) && 
                (
                    this.SuggestionsCount == input.SuggestionsCount ||
                    (this.SuggestionsCount != null &&
                    this.SuggestionsCount.Equals(input.SuggestionsCount))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Released != null)
                    hashCode = hashCode * 59 + this.Released.GetHashCode();
                if (this.Tba != null)
                    hashCode = hashCode * 59 + this.Tba.GetHashCode();
                if (this.BackgroundImage != null)
                    hashCode = hashCode * 59 + this.BackgroundImage.GetHashCode();
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.RatingTop != null)
                    hashCode = hashCode * 59 + this.RatingTop.GetHashCode();
                if (this.Ratings != null)
                    hashCode = hashCode * 59 + this.Ratings.GetHashCode();
                if (this.RatingsCount != null)
                    hashCode = hashCode * 59 + this.RatingsCount.GetHashCode();
                if (this.ReviewsTextCount != null)
                    hashCode = hashCode * 59 + this.ReviewsTextCount.GetHashCode();
                if (this.Added != null)
                    hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.AddedByStatus != null)
                    hashCode = hashCode * 59 + this.AddedByStatus.GetHashCode();
                if (this.Metacritic != null)
                    hashCode = hashCode * 59 + this.Metacritic.GetHashCode();
                if (this.Playtime != null)
                    hashCode = hashCode * 59 + this.Playtime.GetHashCode();
                if (this.SuggestionsCount != null)
                    hashCode = hashCode * 59 + this.SuggestionsCount.GetHashCode();
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
            // Slug (string) minLength
            if(this.Slug != null && this.Slug.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Slug, length must be greater than 1.", new [] { "Slug" });
            }

            // Slug (string) pattern
            Regex regexSlug = new Regex(@"^[-a-zA-Z0-9_]+$", RegexOptions.CultureInvariant);
            if (false == regexSlug.Match(this.Slug).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Slug, must match a pattern of " + regexSlug, new [] { "Slug" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
