﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Demo {
	using System.Diagnostics;
	
	public partial class Basket {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Basket DefaultInstance = new Basket();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 size;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<Fruit> contents;
	
		/// <summary>Initializes a new instance of the Basket class.</summary>
		private Basket()
		{
		}
	
		/// <summary>Initializes a new instance of the Basket class.</summary>
		private Basket(System.Int32 size, System.Collections.Immutable.ImmutableList<Fruit> contents)
		{
			this.size = size;
			this.contents = contents;
			this.Validate();
		}
	
		public static Basket Default {
			get { return DefaultInstance; }
		}
	
		public System.Int32 Size {
			get { return this.size; }
		}
	
		public Basket WithSize(System.Int32 value) {
			if (value == this.Size) {
				return this;
			}
	
			return new Basket(value, this.Contents);
		}
	
		public System.Collections.Immutable.ImmutableList<Fruit> Contents {
			get { return this.contents; }
		}
	
		public Basket WithContents(System.Collections.Immutable.ImmutableList<Fruit> value) {
			if (value == this.Contents) {
				return this;
			}
	
			return new Basket(this.Size, value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public Basket With(
			ImmutableObjectGraph.Optional<System.Int32> size = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Fruit>> contents = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Fruit>>)) {
			return new Basket(
					size.IsDefined ? size.Value : this.Size,
					contents.IsDefined ? contents.Value : this.Contents);
		}
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Basket immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.Int32 size;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.Collections.Immutable.ImmutableList<Fruit> contents;
	
			internal Builder(Basket immutable) {
				this.immutable = immutable;
	
				this.size = immutable.Size;
				this.contents = immutable.Contents;
			}
	
			public System.Int32 Size {
				get {
					return this.size;
				}
	
				set {
					if (this.size != value) {
						this.size = value;
						this.immutable = null;
					}
				}
			}
	
			public System.Collections.Immutable.ImmutableList<Fruit> Contents {
				get {
					return this.contents;
				}
	
				set {
					if (this.contents != value) {
						this.contents = value;
						this.immutable = null;
					}
				}
			}
	
			public Basket ToImmutable() {
				if (this.immutable == null) {
					this.immutable = Basket.Default.With(
						this.size,
						this.contents);
				}
	
				return this.immutable;
			}
		}
	}
	
	public partial class Fruit {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Fruit DefaultInstance = new Fruit();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String color;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 skinThickness;
	
		/// <summary>Initializes a new instance of the Fruit class.</summary>
		private Fruit()
		{
		}
	
		/// <summary>Initializes a new instance of the Fruit class.</summary>
		private Fruit(System.String color, System.Int32 skinThickness)
		{
			this.color = color;
			this.skinThickness = skinThickness;
			this.Validate();
		}
	
		public static Fruit Default {
			get { return DefaultInstance; }
		}
	
		public System.String Color {
			get { return this.color; }
		}
	
		public Fruit WithColor(System.String value) {
			if (value == this.Color) {
				return this;
			}
	
			return new Fruit(value, this.SkinThickness);
		}
	
		public System.Int32 SkinThickness {
			get { return this.skinThickness; }
		}
	
		public Fruit WithSkinThickness(System.Int32 value) {
			if (value == this.SkinThickness) {
				return this;
			}
	
			return new Fruit(this.Color, value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public Fruit With(
			ImmutableObjectGraph.Optional<System.String> color = default(ImmutableObjectGraph.Optional<System.String>), 
			ImmutableObjectGraph.Optional<System.Int32> skinThickness = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return new Fruit(
					color.IsDefined ? color.Value : this.Color,
					skinThickness.IsDefined ? skinThickness.Value : this.SkinThickness);
		}
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Fruit immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.String color;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.Int32 skinThickness;
	
			internal Builder(Fruit immutable) {
				this.immutable = immutable;
	
				this.color = immutable.Color;
				this.skinThickness = immutable.SkinThickness;
			}
	
			public System.String Color {
				get {
					return this.color;
				}
	
				set {
					if (this.color != value) {
						this.color = value;
						this.immutable = null;
					}
				}
			}
	
			public System.Int32 SkinThickness {
				get {
					return this.skinThickness;
				}
	
				set {
					if (this.skinThickness != value) {
						this.skinThickness = value;
						this.immutable = null;
					}
				}
			}
	
			public Fruit ToImmutable() {
				if (this.immutable == null) {
					this.immutable = Fruit.Default.With(
						this.color,
						this.skinThickness);
				}
	
				return this.immutable;
			}
		}
	}
}
