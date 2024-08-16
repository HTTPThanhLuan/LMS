//
// imscp_fileType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace adlcp_rootv1p2.imscp
{
	public class fileType : Altova.Node
	{
		#region Forward constructors
		public fileType() : base() { SetCollectionParents(); }
		public fileType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public fileType(XmlNode node) : base(node) { SetCollectionParents(); }
		public fileType(Altova.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{
			int nCount;

			nCount = DomChildCount(NodeType.Attribute, "", "href");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "href", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			nCount = DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata", i);
				InternalAdjustPrefix(DOMNode, false);
				new metadataType(DOMNode).AdjustPrefix();
			}
		}


		#region href accessor methods
		public int GethrefMinCount()
		{
			return 1;
		}

		public int hrefMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GethrefMaxCount()
		{
			return 1;
		}

		public int hrefMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GethrefCount()
		{
			return DomChildCount(NodeType.Attribute, "", "href");
		}

		public int hrefCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "href");
			}
		}

		public bool Hashref()
		{
			return HasDomChild(NodeType.Attribute, "", "href");
		}

		public hrefType GethrefAt(int index)
		{
			return new hrefType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "href", index)));
		}

		public hrefType Gethref()
		{
			return GethrefAt(0);
		}

		public hrefType href
		{
			get
			{
				return GethrefAt(0);
			}
		}

		public void RemovehrefAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "href", index);
		}

		public void Removehref()
		{
			while (Hashref())
				RemovehrefAt(0);
		}

		public void Addhref(hrefType newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "href", newValue.ToString());
		}

		public void InserthrefAt(hrefType newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "href", index, newValue.ToString());
		}

		public void ReplacehrefAt(hrefType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "href", index, newValue.ToString());
		}
		#endregion // href accessor methods

		#region href collection
        public hrefCollection	Myhrefs = new hrefCollection( );

        public class hrefCollection: IEnumerable
        {
            fileType parent;
            public fileType Parent
			{
				set
				{
					parent = value;
				}
			}
			public hrefEnumerator GetEnumerator() 
			{
				return new hrefEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class hrefEnumerator: IEnumerator 
        {
			int nIndex;
			fileType parent;
			public hrefEnumerator(fileType par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.hrefCount );
			}
			public hrefType  Current 
			{
				get 
				{
					return(parent.GethrefAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}
	
        #endregion // href collection

		#region metadata accessor methods
		public int GetmetadataMinCount()
		{
			return 0;
		}

		public int metadataMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetmetadataMaxCount()
		{
			return 1;
		}

		public int metadataMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetmetadataCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata");
		}

		public int metadataCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata");
			}
		}

		public bool Hasmetadata()
		{
			return HasDomChild(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata");
		}

		public metadataType GetmetadataAt(int index)
		{
			return new metadataType(GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata", index));
		}

		public metadataType Getmetadata()
		{
			return GetmetadataAt(0);
		}

		public metadataType metadata
		{
			get
			{
				return GetmetadataAt(0);
			}
		}

		public void RemovemetadataAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata", index);
		}

		public void Removemetadata()
		{
			while (Hasmetadata())
				RemovemetadataAt(0);
		}

		public void Addmetadata(metadataType newValue)
		{
			AppendDomElement("http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata", newValue);
		}

		public void InsertmetadataAt(metadataType newValue, int index)
		{
			InsertDomElementAt("http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata", index, newValue);
		}

		public void ReplacemetadataAt(metadataType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsproject.org/xsd/imscp_rootv1p1p2", "metadata", index, newValue);
		}
		#endregion // metadata accessor methods

		#region metadata collection
        public metadataCollection	Mymetadatas = new metadataCollection( );

        public class metadataCollection: IEnumerable
        {
            fileType parent;
            public fileType Parent
			{
				set
				{
					parent = value;
				}
			}
			public metadataEnumerator GetEnumerator() 
			{
				return new metadataEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class metadataEnumerator: IEnumerator 
        {
			int nIndex;
			fileType parent;
			public metadataEnumerator(fileType par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.metadataCount );
			}
			public metadataType  Current 
			{
				get 
				{
					return(parent.GetmetadataAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}
	
        #endregion // metadata collection

        private void SetCollectionParents()
        {
            Myhrefs.Parent = this; 
            Mymetadatas.Parent = this; 
	}
}
}
