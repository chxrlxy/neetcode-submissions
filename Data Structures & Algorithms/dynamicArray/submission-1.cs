public class DynamicArray {

    private int[] _dynamicArray;
    private int _capacity;
    private int _length;
    
    public DynamicArray(int capacity) {
        _capacity = capacity;
        _length = 0;
        _dynamicArray = new int[capacity];
    }

    public int Get(int i) {
        return _dynamicArray[i];
    }

    public void Set(int i, int n) {
        _dynamicArray[i] = n;
    }

    public void PushBack(int n) {
        if (GetSize() == GetCapacity())
        {
            Resize();
        }

        _dynamicArray[_length] = n;
        _length++;
    }

    public int PopBack() {
        int lastElement = _dynamicArray[_length-1];

        int[] newArray = new int[_capacity];
        for (int i = 0; i < _length; i++)
        {
            newArray[i] = _dynamicArray[i];
        }

        _dynamicArray = newArray;
        _length--; 
        return lastElement;
    }

    private void Resize() {
        _capacity = _capacity * 2;
        int[] newArray = new int[_capacity];

        for (int i = 0; i < _dynamicArray.Length; i++)
        {
            newArray[i] = _dynamicArray[i];
        }

        _dynamicArray = newArray;
    }

    public int GetSize() {
        return _length;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
