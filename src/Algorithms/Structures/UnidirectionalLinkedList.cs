using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Structures
{
    /// <summary>
    /// Unidirectional linked list
    /// </summary>
    /// <typeparam name="T">Type for which to create the list</typeparam>
    public class UnidirectionalLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Cell of list
        /// </summary>
        public class Cell
        {
            /// <summary>
            /// Shows if a cell is the beginning of the list and contains a value.
            /// If true, it means that the cell is a special cell which is at the beginning of the list and has no value
            /// </summary>
            /// <value>Is special cell</value>
            public bool IsLimiter { get; }

            /// <summary>
            /// Returns the value that the cell stores
            /// </summary>
            /// <value>Cell value</value>
            public T Value { get; }

            /// <summary>
            /// Returns a reference to the next cell
            /// </summary>
            /// <value>Reference to the next cell</value>
            public Cell Next { get; internal set; }

            internal Cell(T value)
            {
                Value = value;
                IsLimiter = false;
            }

            private Cell()
            {
                IsLimiter = true;
            }

            internal static Cell CreateLimiter() => new Cell();
        }

        private Cell top;

        /// <summary>
        /// Creates an instance of an unidirectional linked list
        /// </summary>
        public UnidirectionalLinkedList()
        {
            top = Cell.CreateLimiter();
        }

        /// <summary>
        /// Adds a value to the beginning of the list
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void AddAtBeginning(T value)
        {
            var newCell = new Cell(value);
            newCell.Next = top.Next;
            top.Next = newCell;
        }

        /// <summary>
        /// Adds a value to the end of the list
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void AddAtEnd(T value)
        {
            var current = top;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Cell(value);
        }

        /// <summary>
        /// Inserts a value after the specified cell
        /// </summary>
        /// <param name="after">The cell after which to insert the value</param>
        /// <param name="value">Value to be inserted</param>
        public void Insert(Cell after, T value)
        {
            var newCell = new Cell(value);
            newCell.Next = after.Next;
            after.Next = newCell;
        }

        /// <summary>
        /// Removes the cell reference after the specified cell
        /// </summary>
        /// <param name="after">The cell for which to remove the reference to the next cell</param>
        public void DeleteAfter(Cell after)
        {
            after.Next = after.Next.Next;
        }

        /// <summary>
        /// Finds a cell by its value
        /// </summary>
        /// <param name="target">Target value</param>
        /// <returns>The cell with the target value, or NULL if the cell does not exist</returns>
        public Cell FindCell(T target)
        {
            var current = top.Next;

            while (current != null)
            {
                if (current.Value.Equals(target))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        /// <summary>
        /// Finds the cell that precedes the cell with the target value
        /// </summary>
        /// <param name="target">Target value</param>
        /// <returns>The cell that precedes the cell with the target value, or NULL if the cell does not exist</returns>
        public Cell FindCellBefore(T target)
        {
            var current = top;

            while (current.Next != null)
            {
                if (current.Next.Value.Equals(target))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        /// <summary>
        /// Returns a generic IEnumerator object
        /// </summary>
        /// <returns>IEnumerator object</returns>
        public IEnumerator<T> GetEnumerator()
        {
            var current = top.Next;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Returns a IEnumerator object
        /// </summary>
        /// <returns>IEnumerator object</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
