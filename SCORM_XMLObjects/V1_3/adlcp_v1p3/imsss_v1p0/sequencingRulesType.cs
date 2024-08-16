//
// sequencingRulesType.cs.cs
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

namespace imsss_v1p0
{
	public class sequencingRulesType : Altova.Node
	{
		#region Forward constructors
		public sequencingRulesType() : base() { SetCollectionParents(); }
		public sequencingRulesType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public sequencingRulesType(XmlNode node) : base(node) { SetCollectionParents(); }
		public sequencingRulesType(Altova.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{
			int nCount;

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "preConditionRule");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "preConditionRule", i);
				InternalAdjustPrefix(DOMNode, true);
				new preConditionRuleType(DOMNode).AdjustPrefix();
			}

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "exitConditionRule");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "exitConditionRule", i);
				InternalAdjustPrefix(DOMNode, true);
				new exitConditionRuleType(DOMNode).AdjustPrefix();
			}

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "postConditionRule");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "postConditionRule", i);
				InternalAdjustPrefix(DOMNode, true);
				new postConditionRuleType(DOMNode).AdjustPrefix();
			}
		}


		#region preConditionRule accessor methods
		public int GetpreConditionRuleMinCount()
		{
			return 0;
		}

		public int preConditionRuleMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetpreConditionRuleMaxCount()
		{
			return Int32.MaxValue;
		}

		public int preConditionRuleMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetpreConditionRuleCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "preConditionRule");
		}

		public int preConditionRuleCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "preConditionRule");
			}
		}

		public bool HaspreConditionRule()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "preConditionRule");
		}

		public preConditionRuleType GetpreConditionRuleAt(int index)
		{
			return new preConditionRuleType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "preConditionRule", index));
		}

		public preConditionRuleType GetpreConditionRule()
		{
			return GetpreConditionRuleAt(0);
		}

		public preConditionRuleType preConditionRule
		{
			get
			{
				return GetpreConditionRuleAt(0);
			}
		}

		public void RemovepreConditionRuleAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "preConditionRule", index);
		}

		public void RemovepreConditionRule()
		{
			while (HaspreConditionRule())
				RemovepreConditionRuleAt(0);
		}

		public void AddpreConditionRule(preConditionRuleType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsss", "preConditionRule", newValue);
		}

		public void InsertpreConditionRuleAt(preConditionRuleType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsss", "preConditionRule", index, newValue);
		}

		public void ReplacepreConditionRuleAt(preConditionRuleType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsss", "preConditionRule", index, newValue);
		}
		#endregion // preConditionRule accessor methods

		#region preConditionRule collection
        public preConditionRuleCollection	MypreConditionRules = new preConditionRuleCollection( );

        public class preConditionRuleCollection: IEnumerable
        {
            sequencingRulesType parent;
            public sequencingRulesType Parent
			{
				set
				{
					parent = value;
				}
			}
			public preConditionRuleEnumerator GetEnumerator() 
			{
				return new preConditionRuleEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class preConditionRuleEnumerator: IEnumerator 
        {
			int nIndex;
			sequencingRulesType parent;
			public preConditionRuleEnumerator(sequencingRulesType par) 
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
				return(nIndex < parent.preConditionRuleCount );
			}
			public preConditionRuleType  Current 
			{
				get 
				{
					return(parent.GetpreConditionRuleAt(nIndex));
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
	
        #endregion // preConditionRule collection

		#region exitConditionRule accessor methods
		public int GetexitConditionRuleMinCount()
		{
			return 0;
		}

		public int exitConditionRuleMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetexitConditionRuleMaxCount()
		{
			return Int32.MaxValue;
		}

		public int exitConditionRuleMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetexitConditionRuleCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "exitConditionRule");
		}

		public int exitConditionRuleCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "exitConditionRule");
			}
		}

		public bool HasexitConditionRule()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "exitConditionRule");
		}

		public exitConditionRuleType GetexitConditionRuleAt(int index)
		{
			return new exitConditionRuleType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "exitConditionRule", index));
		}

		public exitConditionRuleType GetexitConditionRule()
		{
			return GetexitConditionRuleAt(0);
		}

		public exitConditionRuleType exitConditionRule
		{
			get
			{
				return GetexitConditionRuleAt(0);
			}
		}

		public void RemoveexitConditionRuleAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "exitConditionRule", index);
		}

		public void RemoveexitConditionRule()
		{
			while (HasexitConditionRule())
				RemoveexitConditionRuleAt(0);
		}

		public void AddexitConditionRule(exitConditionRuleType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsss", "exitConditionRule", newValue);
		}

		public void InsertexitConditionRuleAt(exitConditionRuleType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsss", "exitConditionRule", index, newValue);
		}

		public void ReplaceexitConditionRuleAt(exitConditionRuleType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsss", "exitConditionRule", index, newValue);
		}
		#endregion // exitConditionRule accessor methods

		#region exitConditionRule collection
        public exitConditionRuleCollection	MyexitConditionRules = new exitConditionRuleCollection( );

        public class exitConditionRuleCollection: IEnumerable
        {
            sequencingRulesType parent;
            public sequencingRulesType Parent
			{
				set
				{
					parent = value;
				}
			}
			public exitConditionRuleEnumerator GetEnumerator() 
			{
				return new exitConditionRuleEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class exitConditionRuleEnumerator: IEnumerator 
        {
			int nIndex;
			sequencingRulesType parent;
			public exitConditionRuleEnumerator(sequencingRulesType par) 
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
				return(nIndex < parent.exitConditionRuleCount );
			}
			public exitConditionRuleType  Current 
			{
				get 
				{
					return(parent.GetexitConditionRuleAt(nIndex));
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
	
        #endregion // exitConditionRule collection

		#region postConditionRule accessor methods
		public int GetpostConditionRuleMinCount()
		{
			return 0;
		}

		public int postConditionRuleMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetpostConditionRuleMaxCount()
		{
			return Int32.MaxValue;
		}

		public int postConditionRuleMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetpostConditionRuleCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "postConditionRule");
		}

		public int postConditionRuleCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "postConditionRule");
			}
		}

		public bool HaspostConditionRule()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "postConditionRule");
		}

		public postConditionRuleType GetpostConditionRuleAt(int index)
		{
			return new postConditionRuleType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "postConditionRule", index));
		}

		public postConditionRuleType GetpostConditionRule()
		{
			return GetpostConditionRuleAt(0);
		}

		public postConditionRuleType postConditionRule
		{
			get
			{
				return GetpostConditionRuleAt(0);
			}
		}

		public void RemovepostConditionRuleAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "postConditionRule", index);
		}

		public void RemovepostConditionRule()
		{
			while (HaspostConditionRule())
				RemovepostConditionRuleAt(0);
		}

		public void AddpostConditionRule(postConditionRuleType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsss", "postConditionRule", newValue);
		}

		public void InsertpostConditionRuleAt(postConditionRuleType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsss", "postConditionRule", index, newValue);
		}

		public void ReplacepostConditionRuleAt(postConditionRuleType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsss", "postConditionRule", index, newValue);
		}
		#endregion // postConditionRule accessor methods

		#region postConditionRule collection
        public postConditionRuleCollection	MypostConditionRules = new postConditionRuleCollection( );

        public class postConditionRuleCollection: IEnumerable
        {
            sequencingRulesType parent;
            public sequencingRulesType Parent
			{
				set
				{
					parent = value;
				}
			}
			public postConditionRuleEnumerator GetEnumerator() 
			{
				return new postConditionRuleEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class postConditionRuleEnumerator: IEnumerator 
        {
			int nIndex;
			sequencingRulesType parent;
			public postConditionRuleEnumerator(sequencingRulesType par) 
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
				return(nIndex < parent.postConditionRuleCount );
			}
			public postConditionRuleType  Current 
			{
				get 
				{
					return(parent.GetpostConditionRuleAt(nIndex));
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
	
        #endregion // postConditionRule collection

        private void SetCollectionParents()
        {
            MypreConditionRules.Parent = this; 
            MyexitConditionRules.Parent = this; 
            MypostConditionRules.Parent = this; 
	}
}
}
