using System.IO;
using System.Security.AccessControl;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Linq.Expressions;
using System;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Globalization;


namespace Table_Efficiency_C
{
    delegate void TreeVisitor<T>(T nodeData);

    public class NaryTree<T>
    {
        private T value;
        private LinkedList<NaryTree<T>> node;

        /// <summary>Tree Data Class initiation with valued root and integer amount nodes of valued type T</summary>
        /// <param value="value">The value of type T in the root of the tree</param>
        /// <param node="node">Linked List of Tree Data Class node of the root</param>
        public NaryTree(T value, LinkedList<NaryTree<T>> node) {
            this.value = value;
            this.node = node;
        }

        /// <summary>Tree Data Class initiation with valued root and nulled node </summary>
        /// <param value="value">The value of type T in the root of the tree</param>
        /// <param node="node">null node of the root</param>
        public NaryTree(T value) {
            this.value = value;
            this.node = null;
        }



        /// <summary>Value getter</summary>
        /// <summary>Value setter</summary>
        public T Value { get => this.value; set => this.value = value; }



        /// <summary>Node List getter</summary>
        /// <summary>Node List setter</summary>
        public LinkedList<NaryTree<T>> NodeList { get => this.node; set => this.node = value; }



        public NaryTree<T> getNode(NaryTree<T> target) => this.node.Find(target).Value;
        public NaryTree<T> setNote(NaryTree<T> target, NaryTree<T> node) => this.node.Find(target).Value = node;



        /// <summary>Check for an existent node</summary>
        public bool hasNode() {
            return !this.node.Contains(null);
        }


        
        /// <summary>Append a new linked tree after a node</summary>
        /// <param name="node">Linked tree to append</param>
        public void appendNode(LinkedListNode<NaryTree<T>> node, LinkedListNode<NaryTree<T>> target) {
            this.node.AddAfter(target, node);
        }



        public void replaceChild() {
        }
    }
}
