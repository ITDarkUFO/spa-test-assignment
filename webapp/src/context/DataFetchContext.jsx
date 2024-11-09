import React, { createContext, useContext, useReducer } from 'react';

const DataFetchContext = createContext();

const initialState = { isDataFetchActive: true };

function dataFetchReducer(state, action) {
    switch (action.type) {
        case 'TOGGLE_FETCH':
            return { ...state, isDataFetchActive: !state.isDataFetchActive };
        default:
            return state;
    }
}

export const useDataFetch = () => useContext(DataFetchContext);

export const DataFetchProvider = ({ children }) => {
    const [state, dispatch] = useReducer(dataFetchReducer, initialState);

    return (
        <DataFetchContext.Provider value={{ state, dispatch }}>
            {children}
        </DataFetchContext.Provider>
    );
}
