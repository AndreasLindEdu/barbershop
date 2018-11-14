//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Services</summary>
	[PublishedContentModel("services")]
	public partial class Services : PublishedContentModel, IBaseContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "services";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Services(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Services, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Price: Service price
		///</summary>
		[ImplementPropertyType("price")]
		public decimal Price
		{
			get { return this.GetPropertyValue<decimal>("price"); }
		}

		///<summary>
		/// Service logo: Logo for service
		///</summary>
		[ImplementPropertyType("serviceLogo")]
		public IPublishedContent ServiceLogo
		{
			get { return this.GetPropertyValue<IPublishedContent>("serviceLogo"); }
		}

		///<summary>
		/// Content: Content of post, including text and images
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return Umbraco.Web.PublishedContentModels.BaseContent.GetContent(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.BaseContent.GetHeadline(this); }
		}
	}
}
