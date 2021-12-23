namespace ClipboardHistory
{
    interface ICopyable
    {
        void Push();

        void Pull();

        object GetData();

        bool Equals(ICopyable obj);
    }
}
