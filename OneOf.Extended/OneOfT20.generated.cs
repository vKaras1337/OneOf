using System;
using static OneOf.Functions;

namespace OneOf
{
    public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default, T8 value8 = default, T9 value9 = default, T10 value10 = default, T11 value11 = default, T12 value12 = default, T13 value13 = default, T14 value14 = default, T15 value15 = default, T16 value16 = default, T17 value17 = default, T18 value18 = default, T19 value19 = default, T20 value20 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
            _value8 = value8;
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
        }

        public object Value =>
            _index switch
            {
                0 => _value0,
                1 => _value1,
                2 => _value2,
                3 => _value3,
                4 => _value4,
                5 => _value5,
                6 => _value6,
                7 => _value7,
                8 => _value8,
                9 => _value9,
                10 => _value10,
                11 => _value11,
                12 => _value12,
                13 => _value13,
                14 => _value14,
                15 => _value15,
                16 => _value16,
                17 => _value17,
                18 => _value18,
                19 => _value19,
                20 => _value20,
                _ => throw new InvalidOperationException()
            };

        public int Index => _index;

        public bool IsT0 => _index == 0;
        public bool IsT1 => _index == 1;
        public bool IsT2 => _index == 2;
        public bool IsT3 => _index == 3;
        public bool IsT4 => _index == 4;
        public bool IsT5 => _index == 5;
        public bool IsT6 => _index == 6;
        public bool IsT7 => _index == 7;
        public bool IsT8 => _index == 8;
        public bool IsT9 => _index == 9;
        public bool IsT10 => _index == 10;
        public bool IsT11 => _index == 11;
        public bool IsT12 => _index == 12;
        public bool IsT13 => _index == 13;
        public bool IsT14 => _index == 14;
        public bool IsT15 => _index == 15;
        public bool IsT16 => _index == 16;
        public bool IsT17 => _index == 17;
        public bool IsT18 => _index == 18;
        public bool IsT19 => _index == 19;
        public bool IsT20 => _index == 20;

        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
        public T6 AsT6 =>
            _index == 6 ?
                _value6 :
                throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
        public T7 AsT7 =>
            _index == 7 ?
                _value7 :
                throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
        public T8 AsT8 =>
            _index == 8 ?
                _value8 :
                throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
        public T9 AsT9 =>
            _index == 9 ?
                _value9 :
                throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
        public T10 AsT10 =>
            _index == 10 ?
                _value10 :
                throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
        public T11 AsT11 =>
            _index == 11 ?
                _value11 :
                throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
        public T12 AsT12 =>
            _index == 12 ?
                _value12 :
                throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
        public T13 AsT13 =>
            _index == 13 ?
                _value13 :
                throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
        public T14 AsT14 =>
            _index == 14 ?
                _value14 :
                throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
        public T15 AsT15 =>
            _index == 15 ?
                _value15 :
                throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
        public T16 AsT16 =>
            _index == 16 ?
                _value16 :
                throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
        public T17 AsT17 =>
            _index == 17 ?
                _value17 :
                throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
        public T18 AsT18 =>
            _index == 18 ?
                _value18 :
                throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
        public T19 AsT19 =>
            _index == 19 ?
                _value19 :
                throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
        public T20 AsT20 =>
            _index == 20 ?
                _value20 :
                throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(0, value0: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(1, value1: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(2, value2: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(3, value3: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(4, value4: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(5, value5: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(6, value6: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(7, value7: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T8 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(8, value8: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T9 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(9, value9: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T10 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(10, value10: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T11 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(11, value11: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T12 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(12, value12: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T13 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(13, value13: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T14 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(14, value14: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T15 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(15, value15: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T16 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(16, value16: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T17 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(17, value17: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T18 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(18, value18: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T19 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(19, value19: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T20 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(20, value20: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT5(T5 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT6(T6 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT7(T7 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT8(T8 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT9(T9 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT10(T10 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT11(T11 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT12(T12 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT13(T13 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT14(T14 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT15(T15 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT16(T16 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT17(T17 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT18(T18 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT19(T19 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromT20(T20 input) => input;

        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => mapFunc(input0),
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => mapFunc(input1),
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => mapFunc(input2),
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => mapFunc(input3),
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => mapFunc(input4),
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => mapFunc(input5),
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => mapFunc(input6),
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT7<TResult>(Func<T7, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => mapFunc(input7),
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT8<TResult>(Func<T8, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => mapFunc(input8),
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT9<TResult>(Func<T9, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => mapFunc(input9),
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT10<TResult>(Func<T10, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => mapFunc(input10),
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult, T12, T13, T14, T15, T16, T17, T18, T19, T20> MapT11<TResult>(Func<T11, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => mapFunc(input11),
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult, T13, T14, T15, T16, T17, T18, T19, T20> MapT12<TResult>(Func<T12, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult, T13, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => mapFunc(input12),
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult, T14, T15, T16, T17, T18, T19, T20> MapT13<TResult>(Func<T13, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult, T14, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => mapFunc(input13),
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult, T15, T16, T17, T18, T19, T20> MapT14<TResult>(Func<T14, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult, T15, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => mapFunc(input14),
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult, T16, T17, T18, T19, T20> MapT15<TResult>(Func<T15, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult, T16, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => mapFunc(input15),
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult, T17, T18, T19, T20> MapT16<TResult>(Func<T16, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult, T17, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => mapFunc(input16),
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult, T18, T19, T20> MapT17<TResult>(Func<T17, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult, T18, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => mapFunc(input17),
                input18 => input18,
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult, T19, T20> MapT18<TResult>(Func<T18, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult, T19, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => mapFunc(input18),
                input19 => input19,
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TResult, T20> MapT19<TResult>(Func<T19, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TResult, T20>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => mapFunc(input19),
                input20 => input20
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TResult> MapT20<TResult>(Func<T20, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TResult>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8,
                input9 => input9,
                input10 => input10,
                input11 => input11,
                input12 => input12,
                input13 => input13,
                input14 => input14,
                input15 => input15,
                input16 => input16,
                input17 => input17,
                input18 => input18,
                input19 => input19,
                input20 => mapFunc(input20)
            );
        }
        
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException());
			return this.IsT20;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> other) =>
            _index == other._index &&
            _index switch
            {
                0 => Equals(_value0, other._value0),
                1 => Equals(_value1, other._value1),
                2 => Equals(_value2, other._value2),
                3 => Equals(_value3, other._value3),
                4 => Equals(_value4, other._value4),
                5 => Equals(_value5, other._value5),
                6 => Equals(_value6, other._value6),
                7 => Equals(_value7, other._value7),
                8 => Equals(_value8, other._value8),
                9 => Equals(_value9, other._value9),
                10 => Equals(_value10, other._value10),
                11 => Equals(_value11, other._value11),
                12 => Equals(_value12, other._value12),
                13 => Equals(_value13, other._value13),
                14 => Equals(_value14, other._value14),
                15 => Equals(_value15, other._value15),
                16 => Equals(_value16, other._value16),
                17 => Equals(_value17, other._value17),
                18 => Equals(_value18, other._value18),
                19 => Equals(_value19, other._value19),
                20 => Equals(_value20, other._value20),
                _ => false
            };

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> o && Equals(o);
        }

        public override string ToString() =>
            _index switch {
                0 => FormatValue(_value0),
                1 => FormatValue(_value1),
                2 => FormatValue(_value2),
                3 => FormatValue(_value3),
                4 => FormatValue(_value4),
                5 => FormatValue(_value5),
                6 => FormatValue(_value6),
                7 => FormatValue(_value7),
                8 => FormatValue(_value8),
                9 => FormatValue(_value9),
                10 => FormatValue(_value10),
                11 => FormatValue(_value11),
                12 => FormatValue(_value12),
                13 => FormatValue(_value13),
                14 => FormatValue(_value14),
                15 => FormatValue(_value15),
                16 => FormatValue(_value16),
                17 => FormatValue(_value17),
                18 => FormatValue(_value18),
                19 => FormatValue(_value19),
                20 => FormatValue(_value20),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
                    1 => _value1?.GetHashCode(),
                    2 => _value2?.GetHashCode(),
                    3 => _value3?.GetHashCode(),
                    4 => _value4?.GetHashCode(),
                    5 => _value5?.GetHashCode(),
                    6 => _value6?.GetHashCode(),
                    7 => _value7?.GetHashCode(),
                    8 => _value8?.GetHashCode(),
                    9 => _value9?.GetHashCode(),
                    10 => _value10?.GetHashCode(),
                    11 => _value11?.GetHashCode(),
                    12 => _value12?.GetHashCode(),
                    13 => _value13?.GetHashCode(),
                    14 => _value14?.GetHashCode(),
                    15 => _value15?.GetHashCode(),
                    16 => _value16?.GetHashCode(),
                    17 => _value17?.GetHashCode(),
                    18 => _value18?.GetHashCode(),
                    19 => _value19?.GetHashCode(),
                    20 => _value20?.GetHashCode(),
                    _ => 0
                } ?? 0;
                return (hashCode*397) ^ _index;
            }
        }
    }
}