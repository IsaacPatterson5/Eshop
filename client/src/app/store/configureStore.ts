import { configureStore } from "@reduxjs/toolkit";
import { TypedUseSelectorHook, useDispatch, useSelector } from "react-redux";
import { basketSlice } from "../../features/basket/basketSlice";
import { CatalogSlice } from "../../features/catalog/CatalogSlice";
import { counterSlice } from "../../features/contact/counterSlice";

// export function configureStore() {
// return createStore(counterReducer);
// }

export const store = configureStore({
    reducer: {
        counter: counterSlice.reducer,
        basket: basketSlice.reducer,
        catalog: CatalogSlice.reducer
    }
})

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export const useAppDispatch = () => useDispatch<AppDispatch>();
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;