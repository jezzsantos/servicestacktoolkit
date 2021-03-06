﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// The web services project in the solution
	/// </summary>
	[Description("The web services project in the solution")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "37012148-5679-4bec-8299-e5ba271eac55", ProxyType = typeof(WebServices))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IWebServices : IToolkitInterface
	{

		/// <summary>
		/// The project in the solution that contains the web services
		/// </summary>
		[Description("The project in the solution that contains the web services")]
		[DisplayName("Services Project")]
		[Category("General")]
		String ServicesProject { get; set; }

		/// <summary>
		/// The root namespace of the services project
		/// </summary>
		[Description("The root namespace of the services project")]
		[DisplayName("Root Namespace")]
		[Category("CodeGen")]
		String RootNamespace { get; set; }

		/// <summary>
		/// The display name of the service.
		/// </summary>
		[Description("The display name of the service.")]
		[DisplayName("Service Display Name")]
		[Category("General")]
		String ServiceDisplayName { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IDefaultView Parent { get; }

		/// <summary>
		/// Gets the <see cref="IServices"/> contained in this element.
		/// </summary>
		IServices Services { get; }

		/// <summary>
		/// Gets the <see cref="ITests"/> contained in this element.
		/// </summary>
		ITests Tests { get; }

		/// <summary>
		/// Creates a new <see cref="IServices"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IServices CreateServices(string name, Action<IServices> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Creates a new <see cref="ITests"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		ITests CreateTests(string name, Action<ITests> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// A REST service in the project
	/// </summary>
	[Description("A REST service in the project")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "49ed2bfc-3fc4-4595-8241-8ce44203e52a", ProxyType = typeof(Service))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IService : IToolkitInterface
	{

		/// <summary>
		/// The REST resource name (plural)
		/// </summary>
		[Description("The REST resource name (plural)")]
		[DisplayName("Resource Name")]
		[Category("RESTful")]
		String ResourceName { get; set; }

		/// <summary>
		/// The REST resource name (singular)
		/// </summary>
		[Description("The REST resource name (singular)")]
		[DisplayName("Resource Name (Singular)")]
		[Category("General")]
		String ResourceNameSingular { get; set; }

		/// <summary>
		/// The REST resource name (plural)
		/// </summary>
		[Description("The REST resource name (plural)")]
		[DisplayName("Resource Name (Plural)")]
		[Category("General")]
		String ResourceNamePlural { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IServices Parent { get; }

		/// <summary>
		/// Gets all instances of <see cref="IVerb"/> contained in this element.
		/// </summary>
		IEnumerable<IVerb> Verbs { get; }

		/// <summary>
		/// Gets the <see cref="IResource"/> contained in this element.
		/// </summary>
		IResource Resource { get; }

		/// <summary>
		/// Creates a new <see cref="IVerb"/>  and adds it to the <see cref="Verbs"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IVerb CreateVerb(string name, Action<IVerb> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Creates a new <see cref="IResource"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IResource CreateResource(string name, Action<IResource> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::ServiceStackToolkit.Automation.TypeConverters;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// A HTTP verb
	/// </summary>
	[Description("A HTTP verb")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "39264c19-8dfa-480d-88a3-376e18f316d1", ProxyType = typeof(Verb))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IVerb : IToolkitInterface
	{

		/// <summary>
		/// The type of the verb (i.e. GET, POST, PUT or DELETE)
		/// </summary>
		[Description("The type of the verb (i.e. GET, POST, PUT or DELETE)")]
		[DisplayName("Verb Type")]
		[Category("RESTful")]
		[TypeConverter(typeof(HttpVerbEnumConverter))]
		String VerbType { get; set; }

		/// <summary>
		/// The REST route for the verb
		/// </summary>
		[Description("The REST route for the verb")]
		[DisplayName("Route")]
		[Category("RESTful")]
		String Route { get; set; }

		/// <summary>
		/// Whether the request must be authorized
		/// </summary>
		[Description("Whether the request must be authorized")]
		[DisplayName("Is Authorized")]
		[Category("Security")]
		Boolean IsAuthorized { get; set; }

		/// <summary>
		/// Whether or not this verb handles multiple resources
		/// </summary>
		[Description("Whether or not this verb handles multiple resources")]
		[DisplayName("Has Many")]
		[Category("Design")]
		Boolean HasMany { get; set; }

		/// <summary>
		/// The name of the resource for this verb
		/// </summary>
		[Description("The name of the resource for this verb")]
		[DisplayName("Verb Resource Name")]
		[Category("Design")]
		String VerbResourceName { get; set; }

		/// <summary>
		/// Whether this verb is for testing only (DEBUG=True)
		/// </summary>
		[Description("Whether this verb is for testing only (DEBUG=True)")]
		[DisplayName("Is Testing Only")]
		[Category("CodeGen")]
		Boolean IsTestingOnly { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IService Parent { get; }

		/// <summary>
		/// Gets the <see cref="IResponseContract"/> contained in this element.
		/// </summary>
		IResponseContract ResponseContract { get; }

		/// <summary>
		/// Gets the <see cref="IRequestContract"/> contained in this element.
		/// </summary>
		IRequestContract RequestContract { get; }

		/// <summary>
		/// Creates a new <see cref="IResponseContract"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IResponseContract CreateResponseContract(string name, Action<IResponseContract> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Creates a new <see cref="IRequestContract"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IRequestContract CreateRequestContract(string name, Action<IRequestContract> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// The contract of the response
	/// </summary>
	[Description("The contract of the response")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "b3174220-650b-47b0-8826-bad69eb4fd8a", ProxyType = typeof(ResponseContract))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IResponseContract : IToolkitInterface
	{

		/// <summary>
		/// The name of the class for the contract
		/// </summary>
		[Description("The name of the class for the contract")]
		[DisplayName("Contract Name")]
		[Category("CodeGen")]
		String ContractName { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IVerb Parent { get; }

		/// <summary>
		/// Gets all instances of <see cref="IResponseField"/> contained in this element.
		/// </summary>
		IEnumerable<IResponseField> ResponseFields { get; }

		/// <summary>
		/// Creates a new <see cref="IResponseField"/>  and adds it to the <see cref="ResponseFields"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IResponseField CreateResponseField(string name, Action<IResponseField> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::ServiceStackToolkit.Automation.TypeEditors;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// A field to be returned in the response
	/// </summary>
	[Description("A field to be returned in the response")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "eccdd0e4-490d-4082-9f54-ec3a3246e0e0", ProxyType = typeof(ResponseField))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IResponseField : IToolkitInterface
	{

		/// <summary>
		/// The data type of the field
		/// </summary>
		[Description("The data type of the field")]
		[DisplayName("Data Type")]
		[Category("CodeGen")]
		[Editor(typeof(AnyDataTypePicker), typeof(UITypeEditor))]
		String DataType { get; set; }

		/// <summary>
		/// Optional. The name of the field as it is serialized in the response.
		/// </summary>
		[Description("Optional. The name of the field as it is serialized in the response.")]
		[DisplayName("Serialized Name")]
		[Category("RESTful")]
		String SerializedName { get; set; }

		/// <summary>
		/// The description of the field.
		/// </summary>
		[Description("The description of the field.")]
		[DisplayName("Description")]
		[Category("CodeGen")]
		String Description { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IResponseContract Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// The contract of the request
	/// </summary>
	[Description("The contract of the request")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "91261008-3004-4244-bed7-321a33aefa75", ProxyType = typeof(RequestContract))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IRequestContract : IToolkitInterface
	{

		/// <summary>
		/// The name of the class for the contract
		/// </summary>
		[Description("The name of the class for the contract")]
		[DisplayName("Contract Name")]
		[Category("CodeGen")]
		String ContractName { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IVerb Parent { get; }

		/// <summary>
		/// Gets all instances of <see cref="IRequestField"/> contained in this element.
		/// </summary>
		IEnumerable<IRequestField> RequestFields { get; }

		/// <summary>
		/// Creates a new <see cref="IRequestField"/>  and adds it to the <see cref="RequestFields"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IRequestField CreateRequestField(string name, Action<IRequestField> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// A field to be provided in the request
	/// </summary>
	[Description("A field to be provided in the request")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "47787b3d-2e27-4cf2-bc9f-f3c9c7bb1f35", ProxyType = typeof(RequestField))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IRequestField : IToolkitInterface
	{

		/// <summary>
		/// Whether a value for the field is required in request validation.
		/// </summary>
		[Description("Whether a value for the field is required in request validation.")]
		[DisplayName("Is Required")]
		[Category("Validation")]
		Boolean IsRequired { get; set; }

		/// <summary>
		/// The data type of the field
		/// </summary>
		[Description("The data type of the field")]
		[DisplayName("Data Type")]
		[Category("CodeGen")]
		String DataType { get; set; }

		/// <summary>
		/// Whether this field is included in the 'Route' for this verb.
		/// </summary>
		[Description("Whether this field is included in the 'Route' for this verb.")]
		[DisplayName("Is In Route")]
		[Category("RESTful")]
		Boolean IsInRoute { get; set; }

		/// <summary>
		/// Optional. The name of the field as it is serialized in the request.
		/// </summary>
		[Description("Optional. The name of the field as it is serialized in the request.")]
		[DisplayName("Serialized Name")]
		[Category("RESTful")]
		String SerializedName { get; set; }

		/// <summary>
		/// The description of the field.
		/// </summary>
		[Description("The description of the field.")]
		[DisplayName("Description")]
		[Category("CodeGen")]
		String Description { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IRequestContract Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// The resource being provided by the service
	/// </summary>
	[Description("The resource being provided by the service")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "230b6fc3-2cdc-43a4-a8b4-ce6ff7379bff", ProxyType = typeof(Resource))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IResource : IToolkitInterface
	{

		/// <summary>
		/// The name of the resource
		/// </summary>
		[Description("The name of the resource")]
		[DisplayName("Resource Name")]
		[Category("RESTful")]
		String ResourceName { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IService Parent { get; }

		/// <summary>
		/// Gets all instances of <see cref="IResourceField"/> contained in this element.
		/// </summary>
		IEnumerable<IResourceField> ResourceFields { get; }

		/// <summary>
		/// Creates a new <see cref="IResourceField"/>  and adds it to the <see cref="ResourceFields"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IResourceField CreateResourceField(string name, Action<IResourceField> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::ServiceStackToolkit.Automation.TypeEditors;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// A field of the resource
	/// </summary>
	[Description("A field of the resource")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "fdfa1641-a89c-4719-826f-11f6cd5a53a4", ProxyType = typeof(ResourceField))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IResourceField : IToolkitInterface
	{

		/// <summary>
		/// The data type of the field
		/// </summary>
		[Description("The data type of the field")]
		[DisplayName("Data Type")]
		[Category("CodeGen")]
		[Editor(typeof(AnyDataTypePicker), typeof(UITypeEditor))]
		String DataType { get; set; }

		/// <summary>
		/// The description of the field.
		/// </summary>
		[Description("The description of the field.")]
		[DisplayName("Description")]
		[Category("CodeGen")]
		String Description { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IResource Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// Unit tests for the web service
	/// </summary>
	[Description("Unit tests for the web service")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "f04997c2-ad43-4e17-a78f-e34267c9f5dc", ProxyType = typeof(UnitTests))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IUnitTests : IToolkitInterface
	{

		/// <summary>
		/// The project in the solution that contains the tests
		/// </summary>
		[Description("The project in the solution that contains the tests")]
		[DisplayName("Test Project")]
		[Category("General")]
		String TestProject { get; set; }

		/// <summary>
		/// The root namespace of the services project
		/// </summary>
		[Description("The root namespace of the services project")]
		[DisplayName("Root Namespace")]
		[Category("CodeGen")]
		String RootNamespace { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		ITests Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace ServiceStackToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// Integration tests for the web service
	/// </summary>
	[Description("Integration tests for the web service")]
	[ToolkitInterface(ExtensionId = "B4A8F72C-332B-4154-9351-F7049C24567D", DefinitionId = "edfbc554-33cc-4e05-996b-3ae14a5ff773", ProxyType = typeof(IntegrationTests))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IIntegrationTests : IToolkitInterface
	{

		/// <summary>
		/// The project in the solution that contains the tests
		/// </summary>
		[Description("The project in the solution that contains the tests")]
		[DisplayName("Test Project")]
		[Category("General")]
		String TestProject { get; set; }

		/// <summary>
		/// The root namespace of the services project
		/// </summary>
		[Description("The root namespace of the services project")]
		[DisplayName("Root Namespace")]
		[Category("CodeGen")]
		String RootNamespace { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		ITests Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}
