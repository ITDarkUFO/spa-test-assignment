import React, { createContext, useState, useContext } from 'react';

const ModalContext = createContext();

export const useModal = () => useContext(ModalContext);

export const ModalProvider = ({ children }) => {
    const [isCreateModalVisible, setCreateModalVisible] = useState(false);

    const [isViewEditModalVisible, setViewEditModalVisible] = useState(false);
    const [viewEditModalProductId, setViewEditModalProductId] = useState(null);

    return (
        <ModalContext.Provider value={{
            isCreateModalVisible,
            setCreateModalVisible,

            isViewEditModalVisible,
            setViewEditModalVisible,
            viewEditModalProductId,
            setViewEditModalProductId,
        }}>
            {children}
        </ModalContext.Provider>
    );
}