using Microsoft.AspNetCore.Components;

namespace julyoc.github.io.StatesContainers
{
    public class NavState
    {
        public List<ElementReference> ElementReference { get; set; } = new List<ElementReference>();

        public event Action? LoadElems;

        public void addElemRef (ElementReference elemRef)
        {
            if (ElementReference.Count == 0)
            {
                ElementReference.Add (elemRef);
                ExecuteAction ();
                return;
            }
            if (!ElementReference.Contains (elemRef))
            {
                ElementReference.Add (elemRef);
            }
            ExecuteAction ();
        }

        private void ExecuteAction() => LoadElems!.Invoke ();

    }
}
