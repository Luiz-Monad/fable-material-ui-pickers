namespace Fable.MaterialUI.Pickers
open Fable.Core
open Fable.Core.JsInterop

module Components =
    open Fable.React
    open Fable.MaterialUI.Pickers.Props
    open Fable.MaterialUI.Pickers.Typings
    open Fable.MaterialUI.Pickers.Interfaces

    let toObj p = keyValueList CaseRules.LowerFirst p

    let fromObj<'O, 'P> ( o: 'O ) : 'P seq =
        JS.Object.keys o
        |> Seq.map ( fun key ->
            !! ( key, o?(key) )
        )

    let inline datePicker (b : IDatePickerProps seq) c : ReactElement = ofImport "DatePicker" "@material-ui-pickers/DatePicker" (toObj b) c
    let inline keyboardDatePicker (b : IKeyboardDatePickerProps seq) c : ReactElement = ofImport "KeyboardDatePicker" "@material-ui-pickers/DatePicker" (toObj b) c
    let inline datePickerToolbar (b : IToolbarComponentProps seq) c : ReactElement = ofImport "DatePickerToolbar" "@material-ui-pickers/DatePicker" (toObj b) c

    let inline dateTimePicker (b : IDateTimePickerProps seq) c : ReactElement = ofImport "DateTimePicker" "@material-ui-pickers/DateTimePicker" (toObj b) c
    let inline keyboardDateTimePicker (b : IKeyboardDateTimePickerProps seq) c : ReactElement = ofImport "KeyboardDateTimePicker" "@material-ui-pickers/DateTimePicker" (toObj b) c
    let inline dateTimePickerTabs (b : IDateTimePickerTabsProps seq) c : ReactElement = ofImport "DateTimePickerTabs" "@material-ui-pickers/DateTimePicker" (toObj b) c
    let inline dateTimePickerToolbar (b : IToolbarComponentProps seq) c : ReactElement = ofImport "DateTimePickerToolbar" "@material-ui-pickers/DateTimePicker" (toObj b) c

    let inline picker (b : IPickerProps seq) c : ReactElement = ofImport "Picker" "@material-ui-pickers/Picker" (toObj b) c
    let inline defaultToolbarComponent (b : IToolbarComponentProps seq) c : ReactElement = ofImport "DefaultToolbarComponent" "@material-ui-pickers/WrappedKeyboardPicker" (toObj b) c

    let inline timePicker (b : ITimePickerProps seq) c : ReactElement = ofImport "TimePicker" "@material-ui-pickers/TimePicker" (toObj b) c
    let inline keyboardTimePicker (b : IKeyboardTimePickerProps seq) c : ReactElement = ofImport "KeyboardTimePicker" "@material-ui-pickers/TimePicker" (toObj b) c
    let inline timePickerToolbar (b : IToolbarComponentProps seq) c : ReactElement = ofImport "TimePickerToolbar" "@material-ui-pickers/TimePicker" (toObj b) c
    
    let inline makeKeyboardPicker () : IMakePickerOptions<IWrappedKeyboardPickerPropsAndT<'T>> -> FunctionComponent<IWrappedKeyboardPickerPropsAndT<'T>> = import "makeKeyboardPicker" "@material-ui-pickers/Picker/WrappedKeyboardPicker"
    let inline makePurePicker () : IMakePickerOptions<IWrappedPurePickerPropsAndT<'T>> -> FunctionComponent<IWrappedPurePickerPropsAndT<'T>> = import "makePurePicker" "@material-ui-pickers/Picker/WrappedPurePicker"

    module UtilsProvider =

        let inline muiPickersContext () : IContext<IUtils<MaterialUiPickersDate> option> = import "MuiPickersContext" "@material-ui-pickers/MuiPickersUtilsProvider" 
        let inline MuiPickersUtilsProvider (b : IMuiPickersUtilsProviderProps seq) c : ReactElement = ofImport "MuiPickersUtilsProvider" "@material-ui-pickers/MuiPickersUtilsProvider" (toObj b) c

    module PropTypes =

        let timePickerDefaultProps: IBaseTimePickerProps seq = import "timePickerDefaultProps" "@material-ui-pickers/prop-types" |> fromObj
        let datePickerDefaultProps: IBaseDatePickerProps seq = import "datePickerDefaultProps" "@material-ui-pickers/prop-types" |> fromObj
        let dateTimePickerDefaultProps: IBaseDateTimePickerProps seq = import "dateTimePickerDefaultProps" "@material-ui-pickers/prop-types" |> fromObj 

    module ViewMaps =

        type [<AllowNullLiteral>] Views =
            abstract year: (IViewMap -> ReactElement)
            abstract month: (IViewMap -> ReactElement)
            abstract date: (IViewMap -> ReactElement)
            abstract hours: (IViewMap -> ReactElement)
            abstract minutes: (IViewMap -> ReactElement)
            abstract seconds: (IViewMap -> ReactElement)

        let views: Views = import "viewsMap" "@material-ui-pickers/Picker/Picker"

        let yearView : ReactElementType<IYearSelectionProps seq> = ReactElementType.ofFunction (toObj >> unbox >> views.year)
        let monthView : ReactElementType<IMonthSelectionProps seq> = ReactElementType.ofFunction (toObj >> unbox >> views.month)
        let dateView : ReactElementType<ICalendarProps seq> = ReactElementType.ofFunction (toObj >> unbox >> views.date)
        let hoursView : ReactElementType<ITimePickerViewProps seq> = ReactElementType.ofFunction (toObj >> unbox >> views.hours)
        let minutesView : ReactElementType<ITimePickerViewProps seq> = ReactElementType.ofFunction (toObj >> unbox >> views.minutes)
        let secondsView : ReactElementType<ITimePickerViewProps seq> = ReactElementType.ofFunction (toObj >> unbox >> views.seconds)

    module Wrappers =

        let inline inlineWrapper (b : IInlineWrapperProps<_> seq) c : ReactElement = ofImport "InlineWrapper" "@material-ui-pickers/wrappers" (toObj b) c
        let inline modalWrapper (b : IModalWrapperProps<_> seq) c : ReactElement = ofImport "ModalWrapper" "@material-ui-pickers/wrappers" (toObj b) c
        let inline staticWrapper (b : IStaticWrapperProps seq) c : ReactElement = ofImport "StaticWrapper" "@material-ui-pickers/wrappers" (toObj b) c

        let inline getWrapperFromVariant () : WrapperVariant -> FunctionComponent<U2<IInlineWrapperProps<_>, IModalWrapperProps<_>>> = import "getWrapperFromVariant" "@material-ui-pickers/wrappers/Wrapper"
        let inline variantContext () : IContext<WrapperVariant option> = import "VariantContext" "@material-ui-pickers/wrappers/Wrapper"
        let inline Wrapper (b : IWrappersProps<_> seq) c : ReactElement = ofImport "Wrapper" "@material-ui-pickers/wrappers/Wrapper" (toObj b) c
