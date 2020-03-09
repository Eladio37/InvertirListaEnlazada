using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.ListaEnlazada {
    public class LinkedList {
        private Node head;

        public Node Head {
            get {
                return this.head;
            }
        }

        public LinkedList() {
            this.head = null;
        }

        public void AddItem(int value) {
            Node node = new Node(value);
            if (this.head == null) {
                this.head = node;
            } else {
                node.Next = this.head;
                this.head = node;
            }
        }

        public void Find(int value) {

        }
        public void InverterList(int value)
        {

        }
    }
}
