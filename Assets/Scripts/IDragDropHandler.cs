namespace webgl.utils
{
    interface IDragDropHandler
    {
        void Bind(DragDropController controller);
        void Hook();
        void Unhook();
    }
}